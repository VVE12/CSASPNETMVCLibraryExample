using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CSASPNETMVCLibraryExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Fullbooklist",
                url: "Fulllist",
                defaults: new { controller = "Booklist", action = "Fulllist" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Booklist", action = "Indexbook", id = UrlParameter.Optional }
            );
        }
    }
}
