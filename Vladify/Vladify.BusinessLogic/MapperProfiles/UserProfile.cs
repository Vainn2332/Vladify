using AutoMapper;
using Vladify.BusinessLogic.Models;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRequestModel, User>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));

        CreateMap<UserRequestModel, UserUpdateRequestModel>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<UserUpdateRequestModel, User>()
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));

        CreateMap<User, UserModel>();
    }
}
