using FluentValidation;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Concurrent;
using Vladify.BusinessLogic.Exceptions;

namespace Vladify.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class ValidationFilter : Attribute, IAsyncActionFilter
{
    //for optimizational purposes
    private static readonly ConcurrentDictionary<Type, Type> _cache = [];

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        foreach (var argument in context.ActionArguments.Values)
        {
            if (argument is null) continue;

            var argumentType = argument.GetType();

            var validatorType = _cache.GetOrAdd(argumentType, type =>
                typeof(IValidator<>).MakeGenericType(type)
            );

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
