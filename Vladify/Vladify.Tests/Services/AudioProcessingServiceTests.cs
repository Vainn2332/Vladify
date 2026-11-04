using AutoFixture;
using AutoFixture.AutoMoq;
using FluentAssertions;
using Moq;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Services;

namespace Vladify.UnitTests.Services;

file class PositionTrackingStream(byte[] data) : MemoryStream(data)//class helper to check position to ensure reading stream from start
{
    public List<long> PositionsAtRead { get; } = new();

    public override int Read(byte[] buffer, int offset, int count)
    {
        PositionsAtRead.Add(Position);
        return base.Read(buffer, offset, count);
    }
}

public class AudioProcessingServiceTests
{
    private readonly IFixture _fixture;
    private readonly AudioProcessingService _service;

    public AudioProcessingServiceTests()
    {
        _fixture = new Fixture().Customize(new AutoMoqCustomization());
        _service = _fixture.Create<AudioProcessingService>();
    }

    [Fact]
    public async Task GetSongDurationAsync_ShouldThrowNotSeekableStreamException_WhenStreamCannotSeek()
    {
        var mockStream = _fixture.Create<Mock<Stream>>();
        mockStream.Setup(s => s.CanSeek).Returns(false);

        var act = async () => await _service.GetSongDurationAsync(mockStream.Object);

        await act.Should().ThrowAsync<NotSeekableStreamException>()
            .WithMessage(ErrorMessageConstants.NotSeekableStream);
    }

    [Fact]
    public async Task GetSongDurationAsync_ShouldResetPositionToZero_BeforeAndAfterProcessing()
    {
        var data = _fixture.CreateMany<byte>(1024).ToArray();
        var stream = new PositionTrackingStream(data)
        {
            Position = 100
        };

        try
        {
            await _service.GetSongDurationAsync(stream);
        }
        catch
        {
            // Ignore ATL parsing errors for dummy data
        }

        stream.PositionsAtRead.Should().NotBeEmpty("ATL should have attempted to read from the stream");
        stream.PositionsAtRead.First().Should().Be(0, "Position should be reset to 0 BEFORE reading");
        stream.Position.Should().Be(0, "Position should be reset to 0 AFTER processing");
    }
}
