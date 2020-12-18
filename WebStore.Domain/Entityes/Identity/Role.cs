using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domain.Entityes.Identity
{
    class Role : IdentityRole
    {
        public const string Administrator = "Administrators";

        public const string User = "Users";
    }
}
