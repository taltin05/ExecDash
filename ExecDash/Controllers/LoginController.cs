using ExecDash.DomainModel.Dto;
using ExecDash.DomainModel.Model;
using ExecDash.Services;
using ExecDash.Services.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Collections.Generic;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace ExecDash.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthenticationService authenticationService;

        private IAuthenticationManager OWINAuthentication
        {
            get { return HttpContext.GetOwinContext().Authentication; }
        }

        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }
               
        [HttpGet]
        public ActionResult Login(string redirectUrl)
        {
            ViewBag.RedirectUrl = redirectUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserCredential credential, string redirectUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(credential);
            }
                       

            OWINAuthentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);

            if (!this.authenticationService.IsCredentialAuthenticated(credential.UserName, credential.Password))
            {
                ModelState.AddModelError("ErrorMessage", this.authenticationService.ErrorMessage);
                return View(credential);
            }

            UserIdentifierResult authIdentity = this.authenticationService.AuthenticateUser;

            var claimIdentity = new ClaimsIdentity(CreateClaims(authIdentity), DefaultAuthenticationTypes.ApplicationCookie);

            OWINAuthentication.SignIn(new AuthenticationProperties { IsPersistent = false }, claimIdentity);

            if (string.IsNullOrEmpty(redirectUrl))
            {
                string returnUrl = Url.Action("Index", "Home", new { username = authIdentity.UserName });
                return RedirectPermanent(returnUrl);
            }
            else
                return RedirectPermanent(redirectUrl);
        }

        private List<Claim> CreateClaims(UserIdentifierResult authIdentity)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, authIdentity.UserName),
                 new Claim(ClaimTypes.Email, authIdentity.Email),
                 new Claim(ClaimTypes.Sid, authIdentity.UserID.ToString()),
                 new Claim(ClaimTypes.Role, authIdentity.Role)
            };

            return claims;
        }
    }
}