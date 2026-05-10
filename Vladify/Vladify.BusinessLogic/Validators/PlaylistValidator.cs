using FluentValidation;
using Vladify.BusinessLogic.Models.PlaylistModels;

namespace Vladify.BusinessLogic.Validators;

file static class Constraints
{
    public const int MaxDefaultStringLength = 50;

    public const string FieldRequiredMessage = "Field '{PropertyName}' is required!";

    public const string LengthExceededMessage = "The length of field '{PropertyName}' exceeds {MaxLength}!";
}

public class PlaylistValidator : AbstractValidator<PlaylistAddDto>
{
    public PlaylistValidator()
    {
        RuleFor(playlist => playlist.Name)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);
    }
}
