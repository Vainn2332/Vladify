using AutoMapper;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class SearchService(ISearchRepository _searchRepository, IMapper _mapper) : ISearchService
{
    public async Task<SearchResult> SearchAsync(SearchFilter filter, CancellationToken cancellationToken)
    {
        var query = filter.Query.Trim();

        var songs = await _searchRepository.SearchSongsAsync(query, SearchConstants.SongSearchResultLimit, cancellationToken);
        var playlists = await _searchRepository.SearchPlaylistsAsync(query, SearchConstants.PlaylistSearchResultLimit, cancellationToken);
        var users = await _searchRepository.SearchUsersAsync(query, SearchConstants.UserSearchResultLimit, cancellationToken);

        return new SearchResult
        {
            Songs = _mapper.Map<List<SongSearchResult>>(songs),
            Playlists = _mapper.Map<List<PlaylistSearchResult>>(playlists),
            Users = _mapper.Map<List<UserSearchResult>>(users)
        };
    }
}
