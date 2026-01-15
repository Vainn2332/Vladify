using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vladify.DataAccess.Enums;

namespace Vladify.BusinessLogic.Models
{
    internal class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public required int Age { get; set; }

        public Gender Gender { get; set; } = Gender.Undefined;
    }
}
