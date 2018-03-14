using ExecDash.Web.AppStart;
using ExecDash.Web.IOC;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System.Web.Http;
using Unity.WebApi;


[assembly: OwinStartup(typeof(ExecDash.Web.Startup))]

namespace ExecDash.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/login")
            });

            HttpConfiguration config = new HttpConfiguration()
            {
                DependencyResolver = new UnityDependencyResolver(UnityLoader.GetConfiguredContainer())
            };

            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
