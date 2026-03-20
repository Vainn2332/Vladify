using AutoMapper;
using Vladify.BusinessLogic.Models.UserModels;
using Vladify.DataAccess.Entities;

namespace Vladify.BusinessLogic.MapperProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRequestModel, User>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Gender, opt => opt.Ignore())
            .ForMember(dest => dest.Age, opt => opt.Ignore());

        CreateMap<UserUpdateRequestModel, UserUpdateDto>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());

        CreateMap<UserUpdateDto, User>()
            .ForMember(dest => dest.ExternalId, opt => opt.Ignore());


        CreateMap<User, UserModel>();
    }
}
