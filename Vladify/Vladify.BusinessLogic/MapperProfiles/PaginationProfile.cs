using AutoMapper;
using Vladify.BusinessLogic.Models.Pagination;
using Vladify.DataAccess.Dtos.Pagination;

namespace Vladify.BusinessLogic.MapperProfiles;

public class PaginationProfile : Profile
{
    public PaginationProfile()
    {
        CreateMap(typeof(PagedResult<>), typeof(PagedResponse<>));
    }
}
