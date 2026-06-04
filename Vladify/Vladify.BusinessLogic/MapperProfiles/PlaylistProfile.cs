using AutoMapper;
using Vladify.BusinessLogic.Models.PlaylistModels;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class PlaylistProfile : Profile
{
    public PlaylistProfile()
    {
        CreateMap<PlaylistRequestModel, Playlist>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Owner, opt => opt.Ignore())
            .ForMember(dest => dest.Songs, opt => opt.Ignore());

        CreateMap<Playlist, PlaylistModel>()
            .ForMember(dest => dest.AuthorName,
                opt => opt.MapFrom(src => src.Owner.Name));

        CreateMap<PlaylistAddDto, PlaylistRequestModel>()
            .ForMember(dest => dest.AuthorId, opt => opt.Ignore());
    }
}