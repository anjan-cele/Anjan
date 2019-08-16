using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScaffoldingSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            RedirectToRoute("Employee", new { controller = "Employee", action = "Index" });

            return View();
        }
    }
}
