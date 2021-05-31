using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{   // Routes are configured from most specific to most generic. Default should be at the bottom.
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // New way to create custom routes: 
            routes.MapMvcAttributeRoutes();


            // Old way to create custom routes: 
            // New route for displaying movies by release date (calling the "ByReleaseDate" action).
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    defaults: new { controller = "Movies", action = "ByReleaseDate"}, // action comes from the movies controller.
            //    constraints: new { year = @"\d{4}", month = @"\d{2}"} // Forcing year to be a 4 digit integer.
            // );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
