using AutoMapper;
using Vladify.DataAccess.Interfaces;

namespace Vladify.BusinessLogic.MapperProfiles.Converters;

public class PresignedUrlConverter(IStorageService storageService) : IValueConverter<string, string>
{
    public string Convert(string sourceMember, ResolutionContext context)
    {
        return storageService.GetPresignedUrl(sourceMember);
    }
}
