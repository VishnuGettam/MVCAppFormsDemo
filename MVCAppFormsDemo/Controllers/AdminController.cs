using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppFormsDemo.Controllers
{
    public class AdminController : Controller
    {
        [CustomAuthorization("Admin", "SuperAdmin")]
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}