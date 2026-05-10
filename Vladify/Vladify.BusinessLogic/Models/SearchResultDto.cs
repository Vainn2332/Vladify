using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Models.UserModels;

namespace Vladify.BusinessLogic.Models;

public class SearchResultDto
{
    public ICollection<SongModel> Songs { get; set; } = [];
    public ICollection<UserModel> Users { get; set; } = [];
}
