using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;
using Vladify.BusinessLogic.Exceptions;

namespace Vladify.Filters;

public class ValidationFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        foreach (var argument in context.ActionArguments.Values)
        {
            if (argument is null) continue;

            var validatorType = typeof(IValidator<>).MakeGenericType(argument.GetType());
            var validator = context.HttpContext.RequestServices.GetService(validatorType) as IValidator;

            if (validator is not null)
            {
                var validationContext = new ValidationContext<object>(argument);
                var validationResult = await validator.ValidateAsync(validationContext);

                if (!validationResult.IsValid)
                {
                    throw new ValidationFailedException(validationResult.Errors[0].ErrorMessage);
                }
            }
        }

        await next();
    }
}
