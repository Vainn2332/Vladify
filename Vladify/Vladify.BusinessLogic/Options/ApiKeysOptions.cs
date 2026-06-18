using System.ComponentModel.DataAnnotations;

namespace Vladify.BusinessLogic.Options;

public class ApiKeysOptions
{
    [Required]
    public required string Value { get; set; }
}
