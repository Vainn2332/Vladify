using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vladify.DataAccess.Enums;

namespace Vladify.DataAccess.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public int PasswordHash { get; set; } = 0;
        public int Age { get; set; } = 0;
        public Gender Gender { get; set; } = Gender.Male;
    }
}
