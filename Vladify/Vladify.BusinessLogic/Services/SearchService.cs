using AutoMapper;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.BusinessLogic.ServiceInterfaces;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.Services;

public class SearchService(ISearchRepository searchRepository, IMapper mapper) : ISearchService
{
    public async Task<SearchResultDto> SearchAsync(string query, CancellationToken cancellationToken)
    {
        var (songs, users) = await searchRepository.SearchAsync(query, cancellationToken);

        var songModels = mapper.Map<ICollection<SongModel>>(songs);
        var userModels = mapper.Map<ICollection<UserModel>>(users);

        var searchResult = new SearchResultDto()
        {
            Songs = songModels,
            Users = userModels
        };

        return searchResult;
    }
}
