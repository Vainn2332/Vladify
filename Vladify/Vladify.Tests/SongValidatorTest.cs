using FluentValidation.TestHelper;
using Vladify.BusinessLogic.Models.SongModels;
using Vladify.BusinessLogic.Validators;

namespace Vladify.UnitTests;

public class SongValidatorTest
{
    private readonly SongValidator _songValidator = new SongValidator();

    [Theory]
    [InlineData(nameof(SongRequestModel.Title))]
    [InlineData(nameof(SongRequestModel.Author))]
    [InlineData(nameof(SongRequestModel.Album))]
    public void Should_Return_Error_When_Field_Is_Empty(string propertyName)
    {
        var model = new SongRequestModel
        {
            Title = "Valid",
            Album = "Valid",
            Author = "Valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        typeof(SongRequestModel).GetProperty(propertyName)!.SetValue(model, "");

        var result = _songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"Field '{propertyName}' is required!");
    }

    [Theory]
    [InlineData(nameof(SongRequestModel.Title))]
    [InlineData(nameof(SongRequestModel.Author))]
    [InlineData(nameof(SongRequestModel.Album))]
    public void Should_Return_Error_When_MaxLength_Exceeded(string propertyName)
    {
        string errorString = new string('f', 100);
        var model = new SongRequestModel()
        {
            Album = "valid",
            Author = "valid",
            Title = "valid",
            Duration = TimeSpan.FromMinutes(2)
        };
        typeof(SongRequestModel).GetProperty(propertyName)!.SetValue(model, errorString);

        var result = _songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(propertyName)
            .WithErrorMessage($"The length of field '{propertyName}' exceeds 50!");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(1801)]
    public void Should_Return_Error_When_NotInRange(int seconds)
    {
        var model = new SongRequestModel()
        {
            Title = "valid",
            Album = "valid",
            Author = "valid",
            Duration = TimeSpan.FromSeconds(seconds)
        };

        var result = _songValidator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(p => p.Duration)
            .WithErrorMessage($"Duration must be between 00:00:10 and 00:30:00!");
    }

    [Fact]
    public void Should_Return_Ok_When_AllFields_Are_Correct()
    {
        var model = new SongRequestModel()
        {
            Album = "Break the horizon",
            Author = "ENMY",
            Title = "Clarity",
            Duration = TimeSpan.FromMinutes(3).Add(TimeSpan.FromSeconds(19))
        };

        var result = _songValidator.TestValidate(model);

        result.ShouldNotHaveAnyValidationErrors();
    }
}
