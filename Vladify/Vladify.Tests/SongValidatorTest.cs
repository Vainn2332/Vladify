using FluentValidation.TestHelper;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Validators;

namespace Vladify.UnitTests;

public class SongValidatorTest
{
    [Theory]
    [InlineData(nameof(SongRequestModel.Title))]
    [InlineData(nameof(SongRequestModel.Author))]
    [InlineData(nameof(SongRequestModel.Album))]
    public void SongValidator_Should_ReturnError_When_Field_IsEmpty(string propertyName)
    {
        SongValidator songValidator = new SongValidator();
        var model = new SongRequestModel
        {
            Title = "Valid",
            Album = "Valid",
            Author = "Valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        typeof(SongRequestModel).GetProperty(propertyName)!.SetValue(model, "");

        var result = songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"Field '{propertyName}' is required!");
    }

    [Fact]
    public void SongValidator_Should_ReturnError_When_Duration_IsEmpty()
    {
        SongValidator songValidator = new SongValidator();
        var model = new SongRequestModel
        {
            Title = "Valid",
            Album = "Valid",
            Author = "Valid",
            Duration = TimeSpan.Zero
        };

        var result = songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Duration)
            .WithErrorMessage($"Field 'Duration' is required!");
    }

    [Theory]
    [InlineData(nameof(SongRequestModel.Title))]
    [InlineData(nameof(SongRequestModel.Author))]
    [InlineData(nameof(SongRequestModel.Album))]
    public void SongValidator_Should_ReturnError_When_MaxLength_Exceeded(string propertyName)
    {
        SongValidator songValidator = new SongValidator();
        string errorString = new string('f', 100);
        var model = new SongRequestModel()
        {
            Album = "valid",
            Author = "valid",
            Title = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        typeof(SongRequestModel).GetProperty(propertyName)!.SetValue(model, errorString);

        var result = songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"The length of field '{propertyName}' exceeds 50!");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(1801)]
    public void SongValidator_Should_ReturnError_When_NotInRange(int seconds)
    {
        SongValidator songValidator = new SongValidator();
        var model = new SongRequestModel()
        {
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromSeconds(seconds)
        };

        var result = songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Duration)
            .WithErrorMessage($"Duration must be between 00:00:10 and 00:30:00!");
    }

    [Fact]
    public void SongValidator_Should_ReturnSuccess_When_AllFields_AreCorrect()
    {
        SongValidator songValidator = new SongValidator();
        var model = new SongRequestModel()
        {
            Album = "Break the horizon",
            Author = "ENMY",
            Title = "Clarity",
            Duration = TimeSpan.FromMinutes(3).Add(TimeSpan.FromSeconds(19))
        };

        var result = songValidator.TestValidate(model);

        result.ShouldNotHaveAnyValidationErrors();
    }
}
