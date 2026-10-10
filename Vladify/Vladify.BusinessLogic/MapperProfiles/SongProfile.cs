using AutoMapper;
using Vladify.BusinessLogic.MapperProfiles.Converters;
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
            .ForMember(dest => dest.AudioUrl, opt => opt.Ignore())
            .ForMember(dest => dest.CoverUrl, opt => opt.Ignore())
            .ForMember(dest => dest.Playlists, opt => opt.Ignore());

        CreateMap<Song, SongModel>()
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Owner.Name))
            .ForMember(dest => dest.AudioUrl, opt => opt.ConvertUsing<PresignedUrlConverter, string>())
            .ForMember(dest => dest.CoverUrl, opt => opt.ConvertUsing<PresignedUrlConverter, string>());

        CreateMap<UpdateSongRequestModel, SongUpdateDto>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<SongUpdateDto, Song>()
            .ForMember(dest => dest.Status, opt => opt.Ignore())
            .ForMember(dest => dest.AuthorId, opt => opt.Ignore())
            .ForMember(dest => dest.Duration, opt => opt.Ignore())
            .ForMember(dest => dest.Owner, opt => opt.Ignore())
            .ForMember(dest => dest.Playlists, opt => opt.Ignore())
            .ForMember(dest => dest.AudioUrl, opt => opt.Ignore())
            .ForMember(dest => dest.CoverUrl, opt => opt.Ignore());

        CreateMap<SongModel, SongCreatedMessage>();

        CreateMap<Song, SongSearchResult>()
            .ForMember(dest => dest.Author, opt => opt.MapFrom(src => src.Owner.Name))
            .ForMember(dest => dest.AudioUrl, opt => opt.ConvertUsing<PresignedUrlConverter, string>())
            .ForMember(dest => dest.CoverUrl, opt => opt.ConvertUsing<PresignedUrlConverter, string>());
    }
}
