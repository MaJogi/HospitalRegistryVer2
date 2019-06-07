using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.Core
{
    public static class  UsersRoles
    {
        public static string[] Roles = new string[]{"Admin", "Manager", "Member"};
        public static string DefaultUser = Roles.Last();
        public static string PowerUser = Roles.First();
    }
}
