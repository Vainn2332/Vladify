using AutoMapper;
using Vladify.BusinessLogic.Models;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class SongProfile : Profile
{
    public SongProfile()
    {
        CreateMap<SongRequestModel, Song>();

        CreateMap<SongModel, Song>().ReverseMap();
    }
}
