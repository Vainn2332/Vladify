using FluentValidation;
using Vladify.BusinessLogic.Constants;
using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.Validators;

public class SongValidator : AbstractValidator<SongRequestModel>
{
    public SongValidator()
    {
        RuleFor(song => song.Title)
            .NotEmpty().WithMessage("Field 'Title' is required!")
            .MaximumLength(ValidationConstants.MaxDefaultStringLength).WithMessage("The length of field 'Title' exceeds maximum!");

        RuleFor(song => song.Album)
            .NotEmpty().WithMessage("Field 'Album' is required!")
            .MaximumLength(ValidationConstants.MaxDefaultStringLength).WithMessage("The length of field 'Album' exceeds maximum!");

        RuleFor(song => song.Author)
            .NotEmpty().WithMessage("Field 'Author' is required!")
            .MaximumLength(ValidationConstants.MaxDefaultStringLength).WithMessage("The length of field 'Author' exceeds maximum!");

        RuleFor(song => song.Duration)
            .NotEmpty().WithMessage("Field 'Duration' is required!")
            .InclusiveBetween(ValidationConstants.MinSongDuration, ValidationConstants.MaxSongDuration).WithMessage("Song length must be between 2 and 5 minutes"!);
    }
}
