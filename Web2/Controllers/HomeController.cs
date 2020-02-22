using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Web programming 2";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Daut Molahasanov.";

            return View();
        }
    }
}