using MVCAppFormsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCAppFormsDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel logindetails)
        {
            if (ModelState.IsValid)
            {
                if (logindetails != null)
                {
                    if (logindetails.UserName.ToLower() == "vishnu" && logindetails.Password.ToLower() == "vishnu")
                    {
                        FormsAuthenticationTicket formsAuthenticationTicket = new FormsAuthenticationTicket(

                            1, logindetails.UserName, DateTime.Now, new DateTime().AddDays(2), false, "Admin");

                        FormsAuthentication.SetAuthCookie(formsAuthenticationTicket.ToString(), false);

                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return new HttpUnauthorizedResult("User is UnAuthorized to Access the Site");
                    }
                }
            }

            ModelState.AddModelError("Validate", "There was some error happend in processing");
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}