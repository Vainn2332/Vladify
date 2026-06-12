using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using Moq;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.Services;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests;

namespace Vladify.UnitTests;

public class PlaylistServiceTest
{
    private readonly IFixture _fixture;
    private readonly Mock<IPlaylistRepository> _playlistRepositoryMock;
    private readonly Mock<IRepository<Song>> _songRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly PlaylistService _playlistService;

    public PlaylistServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());
        _playlistRepositoryMock = _fixture.Freeze<Mock<IPlaylistRepository>>();
        _songRepositoryMock = _fixture.Freeze<Mock<IRepository<Song>>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _playlistService = _fixture.Create<PlaylistService>();
    }

    [Fact]
    public async Task AddPlaylistAsync_Should_ReturnPlaylistModel_WhenOk()
    {
        var request = _fixture.Create<PlaylistRequestModel>();
        var playlistEntity = _fixture.Create<Playlist>();
        var expectedModel = _fixture.Create<PlaylistModel>();

        _mapperMock.Setup(m => m.Map<Playlist>(request)).Returns(playlistEntity);
        _playlistRepositoryMock.Setup(m => m.AddPlaylistAsync(playlistEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _mapperMock.Setup(m => m.Map<PlaylistModel>(playlistEntity)).Returns(expectedModel);

        var result = await _playlistService.AddPlaylistAsync(request, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().BeAssignableTo<PlaylistModel>();

        _playlistRepositoryMock.Verify(m => m.AddPlaylistAsync(playlistEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task AddSongToPlaylistAsync_Should_ThrowNotFoundException_WhenPlaylistNotFound()
    {
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var requesterId = Guid.NewGuid();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Playlist?)null);

        var act = async () => await _playlistService.AddSongToPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Playlist with such id not found!");

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.AddSongToPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task AddSongToPlaylistAsync_Should_ThrowNotFoundException_WhenSongNotFound()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);

        var act = async () => await _playlistService.AddSongToPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Song with such id not found!");

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.AddSongToPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task AddSongToPlaylistAsync_Should_ReturnPlaylistModel_WhenOk()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.AuthorId = requesterId;
        var songEntity = _fixture.Create<Song>();
        var newPlaylistEntity = _fixture.Create<Playlist>();
        var expectedModel = _fixture.Create<PlaylistModel>();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _playlistRepositoryMock.Setup(m => m.AddSongToPlaylistAsync(playlistEntity, songEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(newPlaylistEntity);
        _mapperMock.Setup(m => m.Map<PlaylistModel>(newPlaylistEntity)).Returns(expectedModel);

        var result = await _playlistService.AddSongToPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().BeOfType<PlaylistModel>();

        _playlistRepositoryMock.Verify(m => m.AddSongToPlaylistAsync(playlistEntity, songEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetPlaylistByIdAsync_Should_ReturnPlaylistModel_WhenFound()
    {
        var playlistId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        var expectedModel = _fixture.Create<PlaylistModel>();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _mapperMock.Setup(m => m.Map<PlaylistModel>(playlistEntity)).Returns(expectedModel);

        var result = await _playlistService.GetPlaylistByIdAsync(playlistId, false, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().BeOfType<PlaylistModel>();

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(playlistId, false, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetPlaylistByIdAsync_Should_ReturnNull_WhenNotFound()
    {
        var invalidPlaylistId = Guid.NewGuid();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(invalidPlaylistId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Playlist?)null);
        _mapperMock.Setup(m => m.Map<PlaylistModel>(null)).Returns((PlaylistModel)null!);

        var result = await _playlistService.GetPlaylistByIdAsync(invalidPlaylistId, false, CancellationToken.None);

        result.Should().BeNull();

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(invalidPlaylistId, false, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetPlaylistsOfUserAsync_Should_ReturnPlaylists_WhenOk()
    {
        var userId = Guid.NewGuid();
        var paginationFilter = _fixture.Create<PaginationFilter>();
        var playlistsEntityList = _fixture.CreateMany<Playlist>(paginationFilter.PageSize);
        var expectedModels = _fixture.CreateMany<PlaylistModel>(paginationFilter.PageSize);

        _playlistRepositoryMock.Setup(m => m.GetPlaylistsOfUserAsync(userId, paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistsEntityList);
        _mapperMock.Setup(m => m.Map<IEnumerable<PlaylistModel>>(playlistsEntityList))
            .Returns(expectedModels);

        var result = await _playlistService.GetPlaylistsOfUserAsync(userId, paginationFilter, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().HaveCount(paginationFilter.PageSize);

        _playlistRepositoryMock.Verify(m => m.GetPlaylistsOfUserAsync(userId, paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task DeletePlaylistAsync_Should_ThrowNotFoundException_WhenNotFound()
    {
        var invalidPlaylistId = Guid.NewGuid();
        var requesterId = Guid.NewGuid();
        _playlistRepositoryMock.Setup(m => m.GetByIdAsync(invalidPlaylistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Playlist?)null);

        var act = async () => await _playlistService.DeletePlaylistAsync(invalidPlaylistId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Playlist with such id not found!");

        _playlistRepositoryMock.Verify(m => m.GetByIdAsync(invalidPlaylistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Playlist>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeletePlaylistAsync_Should_Delete_WhenExists()
    {
        var requesterId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.AuthorId = requesterId;
        _playlistRepositoryMock.Setup(m => m.GetByIdAsync(playlistEntity.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _playlistRepositoryMock.Setup(m => m.DeleteAsync(playlistEntity, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        var act = async () => await _playlistService.DeletePlaylistAsync(playlistEntity.Id, requesterId, CancellationToken.None);

        await act.Should().NotThrowAsync();

        _playlistRepositoryMock.Verify(m => m.GetByIdAsync(playlistEntity.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteAsync(playlistEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task DeleteSongFromPlaylistAsync_Should_ThrowNotFoundException_WhenPlaylistNotFound()
    {
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var requesterId = Guid.NewGuid();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Playlist?)null);

        var act = async () => await _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Playlist with such id not found!");

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteSongFromPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongFromPlaylistAsync_Should_ThrowNotFoundException_WhenSongNotFound()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.AuthorId = requesterId;

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);

        var act = async () => await _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>()
            .WithMessage("Song with such id not found!");

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteSongFromPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongFromPlaylistAsync_Should_ReturnPlaylistModel_WhenOk()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.AuthorId = requesterId;
        var songEntity = _fixture.Create<Song>();
        var newPlaylistEntity = _fixture.Create<Playlist>();
        var expectedModel = _fixture.Create<PlaylistModel>();
        playlistEntity.Songs = new List<Song>() { songEntity };

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _playlistRepositoryMock.Setup(m => m.DeleteSongFromPlaylistAsync(playlistEntity, songEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(newPlaylistEntity);
        _mapperMock.Setup(m => m.Map<PlaylistModel>(newPlaylistEntity)).Returns(expectedModel);

        var result = await _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().BeOfType<PlaylistModel>();

        _playlistRepositoryMock.Verify(m => m.DeleteSongFromPlaylistAsync(playlistEntity, songEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task AddSongToPlaylistAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();

        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.Id = playlistId;
        playlistEntity.AuthorId = Guid.NewGuid();
        var songEntity = _fixture.Create<Song>();
        songEntity.Id = songId;

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);

        var act = async () => await _playlistService.AddSongToPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>()
            .WithMessage("You don't have permissions to modify this playlist!");

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.AddSongToPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeletePlaylistAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.Id = playlistId;
        playlistEntity.AuthorId = Guid.NewGuid();

        _playlistRepositoryMock.Setup(m => m.GetByIdAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);

        var act = async () => await _playlistService.DeletePlaylistAsync(playlistId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>()
            .WithMessage("You don't have permissions to modify this playlist!");

        _playlistRepositoryMock.Verify(m => m.GetByIdAsync(playlistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Playlist>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongFromPlaylistAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        var requesterId = Guid.NewGuid();
        var playlistId = Guid.NewGuid();
        var songId = Guid.NewGuid();
        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.Id = playlistId;
        playlistEntity.AuthorId = Guid.NewGuid();

        var songEntity = _fixture.Create<Song>();
        songEntity.Id = songId;

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);

        var act = async () => await _playlistService.DeleteSongFromPlaylistAsync(playlistId, songId, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>()
            .WithMessage("You don't have permissions to modify this playlist!");

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(playlistId, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.DeleteSongFromPlaylistAsync(It.IsAny<Playlist>(), It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdatePlaylistAsync_Should_ThrowNotFoundException_WhenPlaylistNotFound()
    {
        var requesterId = Guid.NewGuid();
        var requestModel = _fixture.Create<PlaylistUpdateRequestModel>();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync((Playlist?)null);

        var act = async () => await _playlistService.UpdatePlaylistAsync(requestModel, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<NotFoundException>();

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdatePlaylistAsync_Should_ThrowForbiddenException_WhenUserIsNotOwner()
    {
        // Arrange
        var requesterId = Guid.NewGuid();
        var requestModel = _fixture.Create<PlaylistUpdateRequestModel>();

        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.Id = requestModel.Id;
        playlistEntity.AuthorId = Guid.NewGuid(); // Другой ID автора, не совпадающий с requesterId

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);

        var act = async () => await _playlistService.UpdatePlaylistAsync(requestModel, requesterId, CancellationToken.None);

        await act.Should().ThrowAsync<ForbiddenException>();

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Playlist>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdatePlaylistAsync_Should_ReturnPlaylistModel_WhenOk()
    {
        var requesterId = Guid.NewGuid();
        var requestModel = _fixture.Create<PlaylistUpdateRequestModel>();

        var playlistEntity = _fixture.Create<Playlist>();
        playlistEntity.Id = requestModel.Id;
        playlistEntity.AuthorId = requesterId;

        var updatedPlaylistEntity = _fixture.Create<Playlist>();
        var expectedModel = _fixture.Create<PlaylistModel>();

        _playlistRepositoryMock.Setup(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlistEntity);

        _mapperMock.Setup(m => m.Map(requestModel, playlistEntity)).Returns(playlistEntity);

        _playlistRepositoryMock.Setup(m => m.UpdateAsync(playlistEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(updatedPlaylistEntity);

        _mapperMock.Setup(m => m.Map<PlaylistModel>(updatedPlaylistEntity)).Returns(expectedModel);

        var result = await _playlistService.UpdatePlaylistAsync(requestModel, requesterId, CancellationToken.None);

        result.Should().NotBeNull();
        result.Should().BeOfType<PlaylistModel>();
        result.Should().BeEquivalentTo(expectedModel);

        _playlistRepositoryMock.Verify(m => m.GetPlaylistAsync(requestModel.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _playlistRepositoryMock.Verify(m => m.UpdateAsync(playlistEntity, It.IsAny<CancellationToken>()), Times.Once);
    }
}