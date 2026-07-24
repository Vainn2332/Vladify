using AutoMapper;
using Vladify.BusinessLogic.Messages;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class SongProfile : Profile
{
    public SongProfile()
    {
        CreateMap<SongAddDto, Song>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Owner, opt => opt.Ignore())
            .ForMember(dest => dest.Status, opt => opt.Ignore())
            .ForMember(dest => dest.Playlists, opt => opt.Ignore());

        CreateMap<SongRequestModel, SongAddDto>()
            .ForMember(dest => dest.Author, opt => opt.Ignore())
            .ForMember(dest => dest.AuthorId, opt => opt.Ignore());

        CreateMap<Song, SongModel>()
            .ForMember(dest => dest.Author,
                opt => opt.MapFrom(src => src.Owner.Name));

        CreateMap<UpdateSongRequestModel, SongUpdateDto>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<SongUpdateDto, Song>()
            .ForMember(dest => dest.Status, opt => opt.Ignore())
            .ForMember(dest => dest.AuthorId, opt => opt.Ignore())
            .ForMember(dest => dest.Duration, opt => opt.Ignore())
            .ForMember(dest => dest.Owner, opt => opt.Ignore())
            .ForMember(dest => dest.Playlists, opt => opt.Ignore());

        CreateMap<SongModel, SongCreatedMessage>();
    }
}
