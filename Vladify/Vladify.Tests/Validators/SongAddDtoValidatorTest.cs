using FluentValidation.TestHelper;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Validators;

namespace Vladify.UnitTests.Validators;

public class SongAddDtoValidatorTest
{
    private readonly SongAddDtoValidator _validator = new();

    private static FileData ValidAudio() => new()
    {
        Content = new MemoryStream(new byte[] { 1, 2, 3 }),
        ContentType = "audio/mpeg",
        FileName = "song.mp3",
    };

    private static FileData ValidCover() => new()
    {
        Content = new MemoryStream(new byte[] { 1, 2, 3 }),
        ContentType = "image/jpeg",
        FileName = "cover.jpg",
    };

    private static SongAddDto ValidModel() => new()
    {
        Title = "Valid",
        Album = "Valid",
        Duration = TimeSpan.FromMinutes(2),
        Audio = ValidAudio(),
        Cover = ValidCover(),
    };

    [Theory]
    [InlineData(nameof(SongAddDto.Title))]
    [InlineData(nameof(SongAddDto.Album))]
    public void SongValidator_Should_ReturnError_When_Field_IsEmpty(string propertyName)
    {
        var model = ValidModel();
        typeof(SongAddDto).GetProperty(propertyName)!.SetValue(model, "");

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"Field '{propertyName}' is required!");
    }

    [Fact]
    public void SongValidator_Should_ReturnError_When_Duration_IsEmpty()
    {
        var model = ValidModel();
        model.Duration = TimeSpan.Zero;

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Duration)
            .WithErrorMessage("Field 'Duration' is required!");
    }

    [Theory]
    [InlineData(nameof(SongAddDto.Title))]
    [InlineData(nameof(SongAddDto.Album))]
    public void SongValidator_Should_ReturnError_When_MaxLength_Exceeded(string propertyName)
    {
        var model = ValidModel();
        typeof(SongAddDto).GetProperty(propertyName)!.SetValue(model, new string('f', 100));

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"The length of field '{propertyName}' exceeds 20!"); // было 50
    }

    [Theory]
    [InlineData(5)]
    [InlineData(1801)]
    public void SongValidator_Should_ReturnError_When_NotInRange(int seconds)
    {
        var model = ValidModel();
        model.Duration = TimeSpan.FromSeconds(seconds);

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Duration)
            .WithErrorMessage("Duration must be between 00:00:10 and 00:30:00!");
    }

    [Fact]
    public void SongValidator_Should_ReturnError_When_AudioExtension_NotSupported()
    {
        var model = ValidModel();
        model.Audio.FileName = "song.txt";

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Audio.FileName)
            .WithErrorMessage("Unsupported audio format");
    }

    [Fact]
    public void SongValidator_Should_ReturnError_When_CoverExtension_NotSupported()
    {
        var model = ValidModel();
        model.Cover.FileName = "cover.gif";

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Cover.FileName)
            .WithErrorMessage("Unsupported audio format");
    }

    [Fact]
    public void SongValidator_Should_ReturnSuccess_When_AllFields_AreCorrect()
    {
        var model = ValidModel();
        model.Title = "Clarity";
        model.Album = "Break the horizon";
        model.Duration = TimeSpan.FromMinutes(3).Add(TimeSpan.FromSeconds(19));

        var result = _validator.TestValidate(model);

        result.ShouldNotHaveAnyValidationErrors();
    }
}
