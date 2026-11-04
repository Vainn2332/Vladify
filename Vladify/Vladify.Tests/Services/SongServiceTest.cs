using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using MassTransit;
using Moq;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models.Pagination;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.BusinessLogic.Services;
using Vladify.DataAccess.Dtos;
using Vladify.DataAccess.Dtos.Pagination;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Enums;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests.Infrastructure;

namespace Vladify.UnitTests.Services;

public class SongServiceTest
{
    private readonly IFixture _fixture;
    private readonly Mock<ISongRepository> _songRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly Mock<IAudioProcessingService> _audioProcessingService;
    private readonly Mock<IPublishEndpoint> _publishEndpointMock;
    private readonly Mock<IStorageService> _storageServiceMock;
    private readonly SongService _songService;

    public SongServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());

        _songRepositoryMock = _fixture.Freeze<Mock<ISongRepository>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _storageServiceMock = _fixture.Freeze<Mock<IStorageService>>();
        _audioProcessingService = _fixture.Freeze<Mock<IAudioProcessingService>>();
        _publishEndpointMock = _fixture.Freeze<Mock<IPublishEndpoint>>();
        _songService = _fixture.Create<SongService>();
    }

    [Fact]
    public async Task AddSongAsync_Should_ReturnSongModel_WhenOk()
    {
        var request = _fixture.Create<SongAddDto>();
        request.Audio.Content = new MemoryStream(new byte[] { 1, 2 });
        request.Cover.Content = new MemoryStream(new byte[] { 1, 2 });

        var songEntity = _fixture.Create<Song>();
        var taskDto = _fixture.Create<ModerationTaskDto>();
        var expectedModel = _fixture.Create<SongModel>();
        var songDuration = _fixture.Create<TimeSpan>();

        _audioProcessingService.Setup(m => m.GetSongDurationAsync(It.IsAny<FileStream>()))
            .ReturnsAsync(songDuration);
        _mapperMock.Setup(m => m.Map<Song>(request))
            .Returns(songEntity);
        _songRepositoryMock.Setup(m => m.AddWithoutSaveChanges(songEntity))
            .Returns(songEntity);
        _publishEndpointMock.Setup(m => m.Publish(It.IsAny<SongCreatedMessage>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity))
            .Returns(expectedModel);
        _storageServiceMock.Setup(m => m.UploadAsync(It.IsAny<Stream>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        var result = await _songService.AddSongAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<SongModel>(result);
        Assert.Equal(request.Author, result.Author);

        _songRepositoryMock.Verify(m => m.AddWithoutSaveChanges(songEntity), Times.Once);
        _songRepositoryMock.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Once);
        _storageServiceMock.Verify(m => m.UploadAsync(It.IsAny<Stream>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
        _audioProcessingService.Verify(m => m.GetSongDurationAsync(It.IsAny<FileStream>()), Times.Once);
        _publishEndpointMock.Verify(m => m.Publish(It.IsAny<SongCreatedMessage>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task AddSongAsync_Should_CleanupBlob_WhenFailedToUploadInTheMiddle()
    {
        var request = _fixture.Create<SongAddDto>();
        request.Audio.Content = new MemoryStream(new byte[] { 1, 2 });
        request.Cover.Content = new MemoryStream(new byte[] { 1, 2 });

        var songEntity = _fixture.Create<Song>();
        var taskDto = _fixture.Create<ModerationTaskDto>();
        var expectedModel = _fixture.Create<SongModel>();

        _mapperMock.Setup(m => m.Map<Song>(request)).Returns(songEntity);
        _songRepositoryMock.Setup(m => m.AddWithoutSaveChanges(songEntity))
            .Returns(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity)).Returns(expectedModel);
        _storageServiceMock
            .SetupSequence(m => m.UploadAsync(It.IsAny<Stream>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask)
            .ThrowsAsync(new Exception("Upload failed"));

        _storageServiceMock.Setup(m => m.DeleteAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        var ex = await Assert.ThrowsAsync<Exception>(
            () => _songService.AddSongAsync(request, CancellationToken.None));

        _songRepositoryMock.Verify(m => m.SaveChangesAsync(It.IsAny<CancellationToken>()), Times.Never);
        _storageServiceMock.Verify(m => m.DeleteAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
        _publishEndpointMock.Verify(m => m.Publish(It.IsAny<SongCreatedMessage>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task GetSongsAsync_Should_ReturnSongs_WhenOk()
    {
        var paginationFilter = _fixture.Create<PaginationFilter>();
        var pagedEntities = new PagedResult<Song>
        {
            Data = _fixture.CreateMany<Song>(paginationFilter.PageSize).ToList()
        };
        var expectedResult = new PagedResponse<SongModel>
        {
            Data = _fixture.CreateMany<SongModel>(paginationFilter.PageSize).ToList()
        };

        _songRepositoryMock.Setup(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(pagedEntities);
        _mapperMock.Setup(m => m.Map<PagedResponse<SongModel>>(pagedEntities))
            .Returns(expectedResult);

        var result = await _songService.GetSongsAsync(paginationFilter, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Same(expectedResult, result);
        Assert.Equal(paginationFilter.PageSize, result.Data.Count);

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
    public async Task GetSongsOfAuthorAsync_Should_ReturnOnlyApprovedSongs_When_RequesterIsNotTheAuthor()
    {
        var filter = new PaginationFilter()
        {
            PageNumber = 1,
            PageSize = 15
        };
        var requesterId = Guid.NewGuid();
        var differentAuthorId = Guid.NewGuid();

        var songs = _fixture.CreateMany<Song>(15);
        var approvedSongs = songs.Where(s => s.Status == SongStatus.Approved).ToList();

        var pagedResult = new PagedResult<Song>() { Data = approvedSongs, HasNextPage = false };
        var pagedResponse = new PagedResponse<SongModel>()
        {
            Data = _fixture.CreateMany<SongModel>(approvedSongs.Count).ToList(),
            HasNextPage = false
        };

        _songRepositoryMock.Setup(m => m.GetSongsOfAuthorAsync(differentAuthorId, true, It.IsAny<bool>(), filter.PageNumber, filter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(pagedResult);
        _mapperMock.Setup(m => m.Map<PagedResponse<SongModel>>(pagedResult)).Returns(pagedResponse);

        var result = await _songService.GetSongsOfAuthorAsync(filter, differentAuthorId, requesterId, CancellationToken.None);

        result.Data.Should().BeEquivalentTo(pagedResponse.Data);
        result.Data.Should().AllSatisfy(song => song.IsAuthor.Should().BeFalse("requester is NOT the author"));
    }

    [Fact]
    public async Task GetSongsOfAuthorAsync_Should_ReturnAllSongs_When_RequesterIsTheAuthor()
    {
        var filter = new PaginationFilter()
        {
            PageNumber = 1,
            PageSize = 15
        };
        var requesterId = Guid.NewGuid();

        var songs = _fixture.CreateMany<Song>(15).ToList();

        var pagedResult = new PagedResult<Song>() { Data = songs, HasNextPage = false };
        var pagedResponse = new PagedResponse<SongModel>()
        {
            Data = _fixture.CreateMany<SongModel>(songs.Count).ToList(),
            HasNextPage = false
        };

        _songRepositoryMock.Setup(m => m.GetSongsOfAuthorAsync(requesterId, false, It.IsAny<bool>(), filter.PageNumber, filter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(pagedResult);
        _mapperMock.Setup(m => m.Map<PagedResponse<SongModel>>(pagedResult)).Returns(pagedResponse);

        var result = await _songService.GetSongsOfAuthorAsync(filter, requesterId, requesterId, CancellationToken.None);

        result.Data.Should().BeEquivalentTo(pagedResponse.Data);
        result.Data.Should().AllSatisfy(song => song.IsAuthor.Should().BeTrue("requester  the author"));
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

        _storageServiceMock.Verify(m => m.DeleteAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Never);
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
        _storageServiceMock.Setup(m => m.DeleteAsync(songEntity.AudioUrl, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _songService.DeleteSongAsync(songEntity.Id, requesterId, CancellationToken.None);

        _storageServiceMock.Verify(m => m.DeleteAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(2));
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

        _storageServiceMock.Verify(m => m.DeleteAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Never);
        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }
}
