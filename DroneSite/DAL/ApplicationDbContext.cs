using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DroneSite.DAL
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext()
            : base("DroneSiteModelContainer")
        {
        }

        public static ApplicationD
    }
}