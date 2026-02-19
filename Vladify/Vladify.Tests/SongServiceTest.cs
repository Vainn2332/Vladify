using AutoMapper;
using Moq;
using Vladify.BusinessLogic;
using Vladify.BusinessLogic.Exceptions;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;

namespace Vladify.UnitTests;

public class SongServiceTest
{
    private readonly Mock<IRepository<Song>> _songRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly SongService _songService;
    public SongServiceTest()
    {
        _songRepositoryMock = new Mock<IRepository<Song>>();
        _mapperMock = new Mock<IMapper>();
        _songService = new SongService(_songRepositoryMock.Object, _mapperMock.Object);
    }

    [Fact]
    public async Task AddSongAsync_Should_ReturnSongModel()
    {
        var request = new SongRequestModel()
        {
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        var songEntity = new Song()
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Album = request.Album,
            Author = request.Author,
            Duration = request.Duration
        };
        var songModel = new SongModel()
        {
            Id = songEntity.Id,
            Title = songEntity.Title,
            Album = songEntity.Album,
            Author = songEntity.Author,
            Duration = songEntity.Duration
        };
        _mapperMock.Setup(m => m.Map<Song>(request))
            .Returns(songEntity);
        _songRepositoryMock.Setup(m => m.AddAsync(songEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity))
            .Returns(songModel);

        var result = await _songService.AddSongAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(songEntity.Id, result.Id);

        _songRepositoryMock.Verify(m => m.AddAsync(songEntity, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongsAsync_Should_ReturnSongs()
    {
        var paginationFilter = new PaginationFilter() { PageNumber = 3, PageSize = 2 };
        var songEntityList = new List<Song>()
        {
            new()
            {
                Id=Guid.NewGuid(),
                Title="valid1",
                Album="valid1",
                Author="valid1",
                Duration=TimeSpan.FromMinutes(2)
            },
            new()
            {
                Id=Guid.NewGuid(),
                Title="valid2",
                Album="valid2",
                Author="valid2",
                Duration=TimeSpan.FromMinutes(5)
            }
        };
        var songModelList = new List<SongModel>()
        {
            new()
            {
                Id=songEntityList[0].Id,
                Title="valid1",
                Album="valid1",
                Author="valid1",
                Duration=TimeSpan.FromMinutes(2)
            },
            new()
            {
                Id=songEntityList[1].Id,
                Title="valid2",
                Album="valid2",
                Author="valid2",
                Duration=TimeSpan.FromMinutes(5)
            }
        };
        _songRepositoryMock.Setup(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntityList);
        _mapperMock.Setup(m => m.Map<IEnumerable<SongModel>>(songEntityList))
            .Returns(songModelList);

        var result = await _songService.GetSongsAsync(paginationFilter, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(paginationFilter.PageSize, songModelList.Count);

        _songRepositoryMock.Verify(m => m.GetAllAsync(paginationFilter.PageNumber, paginationFilter.PageSize, It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnSong_When_Found()
    {
        var userId = Guid.NewGuid();
        var songEntity = new Song()
        {
            Id = userId,
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        var songModel = new SongModel()
        {
            Id = songEntity.Id,
            Title = songEntity.Title,
            Album = songEntity.Album,
            Author = songEntity.Author,
            Duration = songEntity.Duration
        };
        _songRepositoryMock.Setup(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(songEntity))
            .Returns(songModel);

        var result = await _songService.GetSongByIdAsync(userId, true, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(result.Id, userId);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task GetSongById_Should_ReturnNull_When_NotFound()
    {
        var userId = Guid.NewGuid();
        _songRepositoryMock.Setup(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);
        _mapperMock.Setup(m => m.Map<SongModel>(null))
            .Returns((SongModel)null!);

        var result = await _songService.GetSongByIdAsync(userId, true, CancellationToken.None);

        Assert.Null(result);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(userId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
    }

    [Fact]
    public async Task UpdateAsync_Should_ReturnNotFoundException_WhenNotFound()
    {
        var invalidSongId = Guid.NewGuid();
        var request = new SongModel()
        {
            Id = invalidSongId,
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        _songRepositoryMock.Setup(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync((Song?)null);

        var exception = await Assert.ThrowsAsync<NotFoundException>(() =>
        _songService.UpdateSongAsync(request, CancellationToken.None));

        Assert.Equal("Song with such id not found!", exception.Message);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(invalidSongId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Never);
    }

    [Fact]
    public async Task UpdateSongAsync_Should_ReturnSongModel()
    {
        var songId = Guid.NewGuid();
        var request = new SongModel()
        {
            Id = songId,
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        var song = new Song()
        {
            Id = songId,
            Title = request.Title,
            Album = request.Album,
            Author = request.Author,
            Duration = request.Duration
        };
        var oldSongEntity = new Song()
        {
            Id = songId,
            Title = "valid2",
            Album = "valid2",
            Author = "valid2",
            Duration = TimeSpan.FromMinutes(10)
        };
        var updatedSongEntity = new Song()
        {
            Id = songId,
            Title = request.Title,
            Album = request.Album,
            Author = request.Author,
            Duration = request.Duration
        };
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, false, It.IsAny<CancellationToken>()))
            .ReturnsAsync(oldSongEntity);
        _mapperMock.Setup(m => m.Map<Song>(request))
            .Returns(updatedSongEntity);
        _songRepositoryMock.Setup(m => m.UpdateAsync(updatedSongEntity, It.IsAny<CancellationToken>()))
            .ReturnsAsync(updatedSongEntity);
        _mapperMock.Setup(m => m.Map<SongModel>(updatedSongEntity))
            .Returns(request);

        var result = await _songService.UpdateSongAsync(request, CancellationToken.None);

        Assert.NotNull(result);
        Assert.Equal(request.Id, result.Id);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.UpdateAsync(updatedSongEntity, It.IsAny<CancellationToken>()), Times.Once);
    }


    [Fact]
    public async Task DeleteAsync_Should_ReturnNotFoundException_WhenNotFound()
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
    public async Task DeleteAsync_Should_Delete_WhenExists()
    {
        var songId = Guid.NewGuid();
        var songEntity = new Song()
        {
            Id = songId,
            Album = "valid",
            Author = "valid",
            Title = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        _songRepositoryMock.Setup(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()))
            .ReturnsAsync(songEntity);
        _songRepositoryMock.Setup(m => m.DeleteAsync(songEntity, It.IsAny<CancellationToken>()))
            .Returns(Task.CompletedTask);

        await _songService.DeleteSongAsync(songId, CancellationToken.None);

        _songRepositoryMock.Verify(m => m.GetByIdAsync(songId, true, It.IsAny<CancellationToken>()), Times.Once);
        _songRepositoryMock.Verify(m => m.DeleteAsync(It.IsAny<Song>(), It.IsAny<CancellationToken>()), Times.Once);
    }
}
