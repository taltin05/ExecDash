using ExecDash.Web.IOC;
using System.Web.Mvc;

namespace ExecDash.Web.AppStart
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = UnityLoader.GetConfiguredContainer();
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }
    }
}