using DroneSite.DAL;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneSite.Users
{
    internal class RoleActions
    {
        //Creates new user and role, if role doesn't already exist
        internal void AddUserAndRole(string firstName, string middleName, string lastName, string username, string password, char type)
        {
            //Create a new database context (sort of the middle man between objects and the database)
            ac216team05dbEntities1 context = new ac216team05dbEntities1();
            IdentityResult IdRoleResult;
            IdentityResult IdUserResult;

            //Create a role store (stores roles) that may only contain the type IdentityRole (EF's built in identity library). We need this to hold
            //the roles we create.
            var roleStore = new RoleStore<IdentityRole>(context);

            //Create a role manager, like above. A role manager needs a role store. We need this class to create/edit user roles.
            var roleMan = new RoleManager<IdentityRole>(roleStore);

            //If the 'User' role doesn't exist in the store already, roleMan creates a new one.
            if (!roleMan.RoleExists(type.ToString()))
            {
                IdRoleResult = roleMan.Create(new IdentityRole { Name = type.ToString() });
            }

            var userMan = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var appUser = new ApplicationUser
            {
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                // TODO: should I be storing these?
                Username = username,
                Password = password
            };

            IdUserResult = userMan.Create(appUser, password);

        }
    }
}