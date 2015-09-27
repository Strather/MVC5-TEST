﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Donations {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Donation", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "WelcomeDefault",
                url: "{controller}/{action}"
            );

            routes.MapRoute(
                name: "SingleName",
                url: "{controller}/{action}/{name}"
            );

            routes.MapRoute(
                name: "Welcome",
                url: "{controller}/{action}/{name}/{numTimes}"
            );
        }
    }
}