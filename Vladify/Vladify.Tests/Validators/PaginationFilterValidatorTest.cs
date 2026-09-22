using FluentValidation.TestHelper;
using Vladify.BusinessLogic.Models.Pagination;
using Vladify.BusinessLogic.Validators;

namespace Vladify.UnitTests.Validators;

public class PaginationFilterValidatorTest
{
    private readonly PaginationFilterValidator _validator = new();

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void PaginationValidator_ShouldReturnError_WhenPageNumber_LessThanOne(int pageNumber)
    {
        var model = new PaginationFilter(pageNumber, 20);

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(filter => filter.PageNumber);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(101)]
    public void PaginationValidator_ShouldReturnError_WhenPageSize_OutOfRange(int pageSize)
    {
        var model = new PaginationFilter(1, pageSize);

        var result = _validator.TestValidate(model);

        result.ShouldHaveValidationErrorFor(filter => filter.PageSize);
    }

    [Fact]
    public void PaginationValidator_ShouldReturnSuccess_WhenValuesAreValid()
    {
        var model = new PaginationFilter(2, 50);

        var result = _validator.TestValidate(model);

        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public void PaginationValidator_ShouldReturnSuccess_WhenDefaults()
    {
        var model = new PaginationFilter();

        var result = _validator.TestValidate(model);

        result.ShouldNotHaveAnyValidationErrors();
    }
}
