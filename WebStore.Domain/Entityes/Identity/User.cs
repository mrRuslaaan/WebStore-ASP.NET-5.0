using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entityes.Identity
{
    public class User : IdentityUser
    {
        public const string Administrator = "Administrator";

        public const string DefaultAdminPassword = "Qwerty";
    }
}
