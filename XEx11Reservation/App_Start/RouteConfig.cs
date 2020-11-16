using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace XEx11Reservation
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // enable FriendlyUrls functionality
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Temporary;
            routes.EnableFriendlyUrls(settings);
            //routes.EnableFriendlyUrls();

            // custom static routes
            routes.MapPageRoute("History", "AboutUs/History", "~/History.aspx");
            routes.MapPageRoute("Directions", "AboutUs/Directions", "~/Directions.aspx");
        }

    }
}
