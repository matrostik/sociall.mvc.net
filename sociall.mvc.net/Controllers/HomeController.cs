using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sociall.mvc.net.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Example of using ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "sociAll.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "About";
            ViewBag.Message = "socials.";

            return View();
        }
    }
}
