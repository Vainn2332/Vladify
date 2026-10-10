using AutoFixture;
using AutoFixture.AutoMoq;
using AutoMapper;
using FluentAssertions;
using FluentValidation;
using Moq;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.Services;
using Vladify.BusinessLogic.Validators;
using Vladify.DataAccess.Entities;
using Vladify.DataAccess.Interfaces;
using Vladify.IntegrationTests.Infrastructure;

namespace Vladify.UnitTests.Services;

public class SearchServiceTest
{
    private readonly IFixture _fixture;
    private readonly Mock<ISearchRepository> _searchRepositoryMock;
    private readonly Mock<IMapper> _mapperMock;
    private readonly SearchService _searchService;

    public SearchServiceTest()
    {
        _fixture = AutoFixtureOptions.CreateFixture().Customize(new AutoMoqCustomization());
        _fixture.Register<IValidator<SearchFilter>>(() => new SearchFilterValidator());
        _searchRepositoryMock = _fixture.Freeze<Mock<ISearchRepository>>();
        _mapperMock = _fixture.Freeze<Mock<IMapper>>();
        _searchService = _fixture.Create<SearchService>();
    }

    [Fact]
    public async Task SearchAsync_Should_ReturnMappedResults_WhenOk()
    {
        var songs = _fixture.CreateMany<Song>().ToList();
        var playlists = _fixture.CreateMany<Playlist>().ToList();
        var users = _fixture.CreateMany<User>().ToList();

        var songResults = _fixture.CreateMany<SongSearchResult>().ToList();
        var playlistResults = _fixture.CreateMany<PlaylistSearchResult>().ToList();
        var userResults = _fixture.CreateMany<UserSearchResult>().ToList();

        _searchRepositoryMock.Setup(m => m.SearchSongsAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(songs);
        _searchRepositoryMock.Setup(m => m.SearchPlaylistsAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(playlists);
        _searchRepositoryMock.Setup(m => m.SearchUsersAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(users);

        _mapperMock.Setup(m => m.Map<List<SongSearchResult>>(songs)).Returns(songResults);
        _mapperMock.Setup(m => m.Map<List<PlaylistSearchResult>>(playlists)).Returns(playlistResults);
        _mapperMock.Setup(m => m.Map<List<UserSearchResult>>(users)).Returns(userResults);

        var result = await _searchService.SearchAsync(new SearchFilter("queen"), CancellationToken.None);

        result.Songs.Should().BeEquivalentTo(songResults);
        result.Playlists.Should().BeEquivalentTo(playlistResults);
        result.Users.Should().BeEquivalentTo(userResults);
    }

    [Fact]
    public async Task SearchAsync_Should_TrimQuery_And_UseLimits()
    {
        _searchRepositoryMock.Setup(m => m.SearchSongsAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([]);
        _searchRepositoryMock.Setup(m => m.SearchPlaylistsAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([]);
        _searchRepositoryMock.Setup(m => m.SearchUsersAsync(It.IsAny<string>(), It.IsAny<int>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync([]);

        await _searchService.SearchAsync(new SearchFilter("  queen  "), CancellationToken.None);

        _searchRepositoryMock.Verify(m => m.SearchSongsAsync("queen", SearchConstants.SongSearchResultLimit, It.IsAny<CancellationToken>()), Times.Once);
        _searchRepositoryMock.Verify(m => m.SearchPlaylistsAsync("queen", SearchConstants.PlaylistSearchResultLimit, It.IsAny<CancellationToken>()), Times.Once);
        _searchRepositoryMock.Verify(m => m.SearchUsersAsync("queen", SearchConstants.UserSearchResultLimit, It.IsAny<CancellationToken>()), Times.Once);
    }
}
