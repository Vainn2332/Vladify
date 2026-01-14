using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vladify.BusinessLogic.Models;

namespace Vladify.BusinessLogic.Validators
{
    public class UserValidator:AbstractValidator<UserLoginModel>
    {
        public UserValidator()
        {
            RuleFor(model => model.EmailAddress).NotEmpty().WithMessage("Email is necessary")
            .EmailAddress().WithMessage("Incorrect format of Email");

            RuleFor(model => model.Password).NotEmpty().WithMessage("Field \"Password\" is necessary")
                .MinimumLength(8).WithMessage("Password must be at least 8 characters long");
        }
    }
}
