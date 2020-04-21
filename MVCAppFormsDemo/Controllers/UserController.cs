using MVCAppFormsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace MVCAppFormsDemo.Controllers
{
    public class UserController : Controller
    {
        private List<User> _userName;

        public UserController()
        {
            _userName = new List<User>()
            {
                new User(){ FirstName="Vishnu",LastName="Gettam",Id=1,Location="Chittoor" },
                new User(){ FirstName="Vihaan",LastName="Gettam",Id=1,Location="Chittoor" },
                new User(){ FirstName="Divya",LastName="Gettam",Id=1,Location="Chittoor" },
                new User(){ FirstName="Lucky",LastName="Gettam",Id=1,Location="Chittoor" }
            };
        }

        // GET: User
        public ActionResult Index()
        {
            return View(_userName);
        }
    }
}