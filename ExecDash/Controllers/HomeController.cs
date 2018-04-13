using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExecDash.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IAuthenticationManager OWINAuthentication
        {
            get { return HttpContext.GetOwinContext().Authentication; }
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SignOut()
        {
            Session.Abandon();
            OWINAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}