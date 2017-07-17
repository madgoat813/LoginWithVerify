using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginWithVerify.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles ="admin")]
        public ActionResult AdminIndex()
        {
            return View();
        }

        [Authorize(Roles = "user")]
        public ActionResult UserIndex()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}