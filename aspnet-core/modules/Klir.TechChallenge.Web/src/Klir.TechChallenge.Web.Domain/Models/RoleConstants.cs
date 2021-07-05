using Klir.TechChallenge.Web.Domain.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klir.TechChallenge.Web.Domain.Models
{
    public static class RoleConstants
    {
        public const string Admin = "Admin";
        public const string SuperAdmin = "Super Admin";
        public const string user = "User";

        public static Role GetDefaultOperationsRole() => new Role
        {
            Name = SuperAdmin
        };
    }
}
