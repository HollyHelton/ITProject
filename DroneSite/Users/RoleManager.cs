using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Users
{
    internal class RoleManager
    {
        //Creates new user and role, if role doesn't already exist
        internal void AddUserAndRole()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;
        }
    }
}