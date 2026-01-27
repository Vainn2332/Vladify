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
            .NotEmpty().WithMessage("Field 'Title' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field 'Title' exceeds maximum!");

        RuleFor(song => song.Album)
            .NotEmpty().WithMessage("Field 'Album' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field 'Album' exceeds maximum!");

        RuleFor(song => song.Author)
            .NotEmpty().WithMessage("Field 'Author' is required!")
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage("The length of field 'Author' exceeds maximum!");

        RuleFor(song => song.Duration)
            .NotEmpty().WithMessage("Field 'Duration' is required!")
            .InclusiveBetween(Constraints.MinSongDuration, Constraints.MaxSongDuration).WithMessage("Song length must be between 2 and 5 minutes"!);
    }
}
