using FluentValidation.TestHelper;
using Vladify.BusinessLogic.Models;
using Vladify.BusinessLogic.Validators;

namespace Vladify.UnitTests.Validators;

public class SearchFilterValidatorTest
{
    private readonly SearchFilterValidator _validator = new();

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void SearchFilterValidator_ShouldReturnError_WhenQueryIsEmpty(string? query)
    {
        var result = _validator.TestValidate(new SearchFilter(query));

        result.ShouldHaveValidationErrorFor(filter => filter.Query);
    }

    [Theory]
    [InlineData("a")]
    [InlineData(" a ")]
    public void SearchFilterValidator_ShouldReturnError_WhenQueryIsTooShort(string query)
    {
        var result = _validator.TestValidate(new SearchFilter(query));

        result.ShouldHaveValidationErrorFor(filter => filter.Query);
    }

    [Fact]
    public void SearchFilterValidator_ShouldReturnError_WhenQueryIsTooLong()
    {
        var result = _validator.TestValidate(new SearchFilter(new string('a', 101)));

        result.ShouldHaveValidationErrorFor(filter => filter.Query);
    }

    [Theory]
    [InlineData("ab")]
    [InlineData("  queen  ")]
    public void SearchFilterValidator_ShouldReturnSuccess_WhenQueryIsValid(string query)
    {
        var result = _validator.TestValidate(new SearchFilter(query));

        result.ShouldNotHaveAnyValidationErrors();
    }
}
