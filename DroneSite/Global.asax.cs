﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using DroneSite.Identity;

namespace DroneSite
{
    public class Global : HttpApplication
    {
        public object RouteConfig { get; private set; }

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
           // RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            RoleActions roleActions = new RoleActions();
            roleActions.AddUserToRole();
        }
    }
}