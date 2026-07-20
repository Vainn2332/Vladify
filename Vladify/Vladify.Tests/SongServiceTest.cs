using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using Moq;
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
    private readonly SongService _songService;
    public SongServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());
        _songRepositoryMock = _fixture.Freeze<Mock<ISongRepository>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _songService = _fixture.Create<SongService>();
    }

    [Fact]
    public async Task AddSongAsync_Should_ReturnSongModel_WhenOk()
    {
        var request = _fixture.Create<SongRequestModel>();
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

        _songRepositoryMock.Verify(m => m.AddWithoutSaveChanges(songEntity), Times.Once);
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
        Assert.Equal(paginationFilter.PageSize, expectedModels.Count());

        _songRepositoryMock.Verify(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnSong_WhenFound()
    {
        var songEntity = _fixture.Create<Song>();
        var songModel = _fixture.Create<SongModel>();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity))
            .Returns(songModel);

        var result = await _songService.GetSongByIdAsync(songEntity.Id, true, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsType<SongModel>(result);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songEntity.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnNull_WhenNotFound()
    {
        var invalidSongId = Guid.NewGuid();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);
        _mapperMock.Setup(m => m.Map<SongModel>(null))
            .Returns((SongModel)null!);

        var result = await _songService.GetSongByIdAsync(invalidSongId, true, CancellationToken.None);

        Assert.Null(result);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var request = _fixture.Create<SongUpdateDto>();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
             .ReturnsAsync((Song?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _songService.UpdateSongAsync(request, CancellationToken.None));

        Assert.Equal("Song with such id not found!", exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_ReturnSongModel_WhenOk()
    {
        var request = _fixture.Create<SongUpdateDto>();
        var songEntity = _fixture.Create<Song>();
        var oldSongEntity = _fixture.Create<Song>();
        var updatedSongEntity = _fixture.Create<Song>();
        var expectedModel = _fixture.Create<SongModel>();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldSongEntity);
        _mapperMock.Setup(m => m.Map<Song>(request))
            .Returns(songEntity);
        _songRepositoryMock.Setup(m => m.UpdateAsync(songEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(updatedSongEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(updatedSongEntity))
            .Returns(expectedModel);

        var result = await _songService.UpdateSongAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.IsAssignableFrom<SongModel>(result);

        _songRepositoryMock.Verify(m => m.UpdateAsync(songEntity, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, false, It.IsAny<CancellationToken>()), Times.Once);
    }


    [Fact]
    public async Task DeleteSongAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var invalidSongId = Guid.NewGuid();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _songService.DeleteSongAsync(invalidSongId, CancellationToken.None));

        Assert.Equal("Song with such id not found!", exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task DeleteSongAsync_Should_Delete_WhenExists()
    {
        var request = _fixture.Create<Song>();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(request);
        _songRepositoryMock.Setup(m => m.DeleteAsync(request, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _songService.DeleteSongAsync(request.Id, CancellationToken.None);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(request.Id, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
