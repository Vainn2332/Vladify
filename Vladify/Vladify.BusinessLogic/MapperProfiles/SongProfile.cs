using AutoMapper;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class SongProfile : Profile
{
    public SongProfile()
    {
        CreateMap<SongRequestModel, Song>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Owner, opt => opt.Ignore())
            .ForMember(dest => dest.Playlists, opt => opt.Ignore());

        CreateMap<SongRequestModel, SongModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<Song, SongModel>()
           .ForMember(dest => dest.Author,
               opt => opt.MapFrom(src => src.Owner.Name));

        CreateMap<SongModel, Song>()
          .ForMember(dest => dest.Owner, opt => opt.Ignore())
          .ForMember(dest => dest.Playlists, opt => opt.Ignore());

        CreateMap<Song, SongCreatedMessage>();
    }
}
