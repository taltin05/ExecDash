using System.Web.Mvc;
using System.Web.Routing;

namespace ExecDash.Web.AppStart
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Login",
              url: "login/{action}/{id}",
              defaults: new { controller = "login", action = "login", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "SignOut",
                url: "home/signout",
                defaults: new { controller = "home", action = "signout" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{*path}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
