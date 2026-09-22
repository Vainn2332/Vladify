using FluentValidation;
using Vladify.BusinessLogic.Models.Pagination;

namespace Vladify.BusinessLogic.Validators;

file static class Constraints
{
    public const int MaxPageSize = 100;

    public const string NonNegativeValueMessage = "{PropertyName} must be greater than or equal to 1.";

    public const string BetweenValueMessage = "{PropertyName} must be between {From} and {To}.";
}

public class PaginationFilterValidator : AbstractValidator<PaginationFilter>
{

    public PaginationFilterValidator()
    {
        RuleFor(filter => filter.PageNumber)
            .GreaterThanOrEqualTo(1)
            .WithMessage(Constraints.NonNegativeValueMessage);

        RuleFor(filter => filter.PageSize)
            .InclusiveBetween(1, Constraints.MaxPageSize)
            .WithMessage(Constraints.BetweenValueMessage);
    }
}
