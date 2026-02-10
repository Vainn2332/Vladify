using FluentValidation;
using Vladify.BusinessLogic.Models.SongModels;

namespace Vladify.BusinessLogic.Validators;

file static class Constraints
{
    public const int MaxDefaultStringLength = 50;

    public static readonly TimeSpan MinSongDuration = TimeSpan.FromSeconds(10);

    public static readonly TimeSpan MaxSongDuration = TimeSpan.FromMinutes(30);

    public const string LengthExceededMessage = "The length of field '{PropertyName}' exceeds {MaxLength}!";

    public const string FieldRequiredMessage = "Field '{PropertyName}' is required!";

    public const string BetweenValueMessage = "{PropertyName} must be between {From} and {To}!";
}

public class SongValidator : AbstractValidator<SongRequestModel>
{
    public SongValidator()
    {
        RuleFor(song => song.Title)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);

        RuleFor(song => song.Album)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);

        RuleFor(song => song.Author)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);

        RuleFor(song => song.Duration)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .InclusiveBetween(Constraints.MinSongDuration, Constraints.MaxSongDuration).WithMessage(Constraints.BetweenValueMessage);
    }
}
