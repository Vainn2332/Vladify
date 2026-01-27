using FluentValidation;
using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.Validators;
file static class Constraints
{
    public const int MaxDefaultStringLength = 50;

    public static readonly TimeSpan MinSongDuration = TimeSpan.FromSeconds(10);

    public static readonly TimeSpan MaxSongDuration = TimeSpan.FromMinutes(30);
}

public class SongValidator : AbstractValidator<SongRequestModel>
{
    public SongValidator()
    {
        RuleFor(song => song.Title)
            .NotEmpty().WithMessage("Field '{PropertyName}' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field '{PropertyName}' exceeds {MaxLength}!");

        RuleFor(song => song.Album)
            .NotEmpty().WithMessage("Field '{PropertyName}' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field '{PropertyName}' exceeds {MaxLength}!");

        RuleFor(song => song.Author)
            .NotEmpty().WithMessage("Field '{PropertyName}' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field '{PropertyName}' exceeds {MaxLength}!");

        RuleFor(song => song.Duration)
            .NotEmpty().WithMessage("Field '{PropertyName}' is required!")
            .InclusiveBetween(Constraints.MinSongDuration, Constraints.MaxSongDuration).WithMessage("{PropertyName} must be between {From} and {To}!");
    }
}
