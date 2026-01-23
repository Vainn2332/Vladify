using AutoMapper;
using Vladify.BusinessLogic.Models;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class SongProfile : Profile
{
    public SongProfile()
    {
        CreateMap<SongRequestModel, Song>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<SongRequestModel, SongModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<SongModel, Song>().ReverseMap();
    }
}
