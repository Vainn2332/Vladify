using FluentValidation;
using Vladify.BusinessLogic.Models.SongModels;

namespace Vladify.BusinessLogic.Validators;

file static class Constraints
{
    public const int MaxDefaultStringLength = 20;

    public static readonly TimeSpan MinSongDuration = TimeSpan.FromSeconds(10);

    public static readonly TimeSpan MaxSongDuration = TimeSpan.FromMinutes(30);

    public static readonly string[] AudioExtensions = { ".mp3", ".wav", ".flac" };
    public static readonly string[] CoverImageExtensions = { ".jpg", ".jpeg", ".png", ".icon" };

    public const string LengthExceededMessage = "The length of field '{PropertyName}' exceeds {MaxLength}!";

    public const string FieldRequiredMessage = "Field '{PropertyName}' is required!";

    public const string BetweenValueMessage = "{PropertyName} must be between {From} and {To}!";
}

public class SongAddDtoValidator : AbstractValidator<SongAddDto>
{
    public SongAddDtoValidator()
    {
        RuleFor(song => song.Title)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);

        RuleFor(song => song.Album)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .MaximumLength(Constraints.MaxDefaultStringLength).WithMessage(Constraints.LengthExceededMessage);

        RuleFor(song => song.Duration)
            .NotEmpty().WithMessage(Constraints.FieldRequiredMessage)
            .InclusiveBetween(Constraints.MinSongDuration, Constraints.MaxSongDuration).WithMessage(Constraints.BetweenValueMessage);

        RuleFor(x => x.Audio).NotNull()
            .WithMessage(Constraints.FieldRequiredMessage);
        RuleFor(x => x.Audio.FileName)
            .Must(file => Constraints.AudioExtensions.Contains(Path.GetExtension(file).ToLowerInvariant()))
            .When(x => x.Audio is not null)
            .WithMessage("Unsupported audio format");

        RuleFor(x => x.Cover).NotNull()
           .WithMessage(Constraints.FieldRequiredMessage);
        RuleFor(x => x.Cover.FileName)
           .Must(file => Constraints.CoverImageExtensions.Contains(Path.GetExtension(file).ToLowerInvariant()))
           .When(x => x.Cover is not null)
           .WithMessage("Unsupported audio format");
    }
}
