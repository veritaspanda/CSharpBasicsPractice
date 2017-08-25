using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Configuration;
using System.Web.Security;

namespace CSharpBasics
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            // --http://localhost/scriptresource.axd/foo
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // --http://localhost/Hello
            routes.MapRoute(
                name: "SayHello",
                url: "Hello/",
                defaults: new { controller = "Hello", action = "SayHello"}
                );

            // --http://localhost/Process/
            routes.MapRoute(
                name: "Process",
                url: "Process/{action}/{id}",
                defaults: new { controller = "Process", action = "List", id = "" }
                );



            // --http://localhost/
            // --http://localhost/Home/
            // --http://localhost/Home/About/
            // --http://localhost/Proccess/List/1/
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
