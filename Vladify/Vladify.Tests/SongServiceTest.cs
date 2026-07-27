using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using MassTransit;
using Moq;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Services;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests;

namespace Vladify.UnitTests;

public class SongServiceTest
{
    private readonly IFixture _fixture;
    private readonly Mock<ISongRepository> _songRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly Mock<IPublishEndpoint> _publishEndpointMock;
    private readonly SongService _songService;

    public SongServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());

        _songRepositoryMock = _fixture.Freeze<Mock<ISongRepository>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _publishEndpointMock = _fixture.Freeze<Mock<IPublishEndpoint>>();

        _songService = _fixture.Create<SongService>();
    }

    [Fact]
    public async Task AddSongAsync_Should_ReturnSongModel_WhenOk()
    {
        var request = _fixture.Create<SongAddDto>();
        var songEntity = _fixture.Create<Song>();
        var expectedModel = _fixture.Create<SongModel>();
        var message = _fixture.Create<SongCreatedMessage>();

        _mapperMock.Setup(m => m.Map<Song>(request)).Returns(songEntity);
        _songRepositoryMock.Setup(m => m.AddWithoutSaveChanges(songEntity))
            .Returns(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity)).Returns(expectedModel);
        _mapperMock.Setup(m => m.Map<SongCreatedMessage>(expectedModel)).Returns(message);

        var result = await _songService.AddSongAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<SongModel>(result);
        Assert.Equal(request.Author, result.Author);

        _songRepositoryMock.Verify(m => m.AddWithoutSaveChanges(songEntity), Times.Once);
        _publishEndpointMock.Verify(m => m.Publish(message, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongsAsync_Should_ReturnSongs_WhenOk()
    {
        var paginationFilter = _fixture.Create<PaginationFilter>();
        var songEntityList = _fixture.CreateMany<Song>(paginationFilter.PageSize);
        var expectedModels = _fixture.CreateMany<SongModel>(paginationFilter.PageSize);

        _songRepositoryMock.Setup(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntityList);
        _mapperMock.Setup(m => m.Map<IEnumerable<SongModel>>(songEntityList))
            .Returns(expectedModels);

        var result = await _songService.GetSongsAsync(paginationFilter, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(paginationFilter.PageSize, result.Count());

        _songRepositoryMock.Verify(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnSong_WhenFound()
    {
        var songEntity = _fixture.Create<Song>();
        var songModel = _fixture.Create<SongModel>();

        _songRepositoryMock.Setup(m => m.GetApprovedSongByIdAsync(songEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity))
            .Returns(songModel);

        var result = await _songService.GetSongByIdAsync(songEntity.Id, true, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<SongModel>(result);

        _songRepositoryMock.Verify(m => m.GetApprovedSongByIdAsync(songEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnNull_WhenNotFound()
    {
        var invalidSongId = Guid.NewGuid();

        _songRepositoryMock.Setup(m => m.GetApprovedSongByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);
        _mapperMock.Setup(m => m.Map<SongModel>(null))
            .Returns((SongModel)null!);

        var result = await _songService.GetSongByIdAsync(invalidSongId, true, CancellationToken.None);

        Assert.Null(result);

        _songRepositoryMock.Verify(m => m.GetApprovedSongByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var request = _fixture.Create<SongUpdateDto>();
        var requesterId = Guid.NewGuid();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
             .ReturnsAsync((Song?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _songService.UpdateSongAsync(request, requesterId, CancellationToken.None));

        Assert.Equal("Song with such id not found!", exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_ReturnSongModel_WhenOk()
    {
        var request = _fixture.Create<SongUpdateDto>();
        var requesterId = Guid.NewGuid();

        var oldSongEntity = _fixture.Build<Song>().With(s => s.AuthorId, requesterId).Create();
        var expectedModel = _fixture.Create<SongModel>();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldSongEntity);
        _mapperMock.Setup(m => m.Map(request, oldSongEntity))
            .Returns(oldSongEntity);
        _songRepositoryMock.Setup(m => m.UpdateAsync(oldSongEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldSongEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(oldSongEntity))
            .Returns(expectedModel);

        var result = await _songService.UpdateSongAsync(request, requesterId, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsAssignableFrom<SongModel>(result);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(oldSongEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateSongAsync_ShouldThrowForbiddenException_WhenUserIsNotAuthor()
    {
        var request = _fixture.Create<SongUpdateDto>();
        var requesterId = Guid.NewGuid();
        var differentAuthorId = Guid.NewGuid();

        var songEntity = _fixture.Build<Song>()
            .With(s => s.AuthorId, differentAuthorId)
            .Create();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);

        var exception = await Assert.ThrowsAsync<ForbiddenException>(() =>
            _songService.UpdateSongAsync(request, requesterId, CancellationToken.None));

        Assert.Equal(ErrorMessageConstants.SongForbidden, exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var invalidSongId = Guid.NewGuid();
        var requesterId = Guid.NewGuid();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
            _songService.DeleteSongAsync(invalidSongId, requesterId, CancellationToken.None));

        Assert.Equal("Song with such id not found!", exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_Delete_WhenExists()
    {
        var requesterId = Guid.NewGuid();
        var songEntity = _fixture.Build<Song>().With(s => s.AuthorId, requesterId).Create();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(songEntity.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);

        _songRepositoryMock.Setup(m => m.DeleteAsync(songEntity, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _songService.DeleteSongAsync(songEntity.Id, requesterId, CancellationToken.None);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songEntity.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(songEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task DeleteSongAsync_ShouldThrowForbiddenException_WhenUserIsNotAuthor()
    {
        var songId = Guid.NewGuid();
        var requesterId = Guid.NewGuid();
        var differentAuthorId = Guid.NewGuid();

        var songEntity = _fixture.Build<Song>()
            .With(s => s.Id, songId)
            .With(s => s.AuthorId, differentAuthorId)
            .Create();

        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);

        var exception = await Assert.ThrowsAsync<ForbiddenException>(() =>
            _songService.DeleteSongAsync(songId, requesterId, CancellationToken.None));

        Assert.Equal(ErrorMessageConstants.SongForbidden, exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }
}
