using FluentValidation;
using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.Validators;

file static class Constraints
{
    public const int MinQueryLength = 2;

    public const int MaxQueryLength = 100;

    public const string FieldRequiredMessage = "Field '{PropertyName}' is required!";

    public const string LengthMessage = "The length of field '{PropertyName}' must be between 2 and 100!";
}

public class SearchFilterValidator : AbstractValidator<SearchFilter>
{
    public SearchFilterValidator()
    {
        RuleFor(filter => filter.Query)
            .Cascade(CascadeMode.Stop)
            .Must(query => !string.IsNullOrWhiteSpace(query))
            .WithMessage(Constraints.FieldRequiredMessage)
            .Must(query => query.Trim().Length is >= Constraints.MinQueryLength and <= Constraints.MaxQueryLength)
            .WithMessage(Constraints.LengthMessage);
    }
}
