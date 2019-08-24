using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace ScaffoldingSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            //RedirectToRoute("Employee", new { controller = "Employee", action = "Index" });

            //IsMobileDevice();


            if (Request.UserAgent.Contains("Mobi") == true)
            {
                return View("MobileIndex");
            }
            else
            {
                return View();
            }

        }

        public bool IsMobileDevice()
        {
            bool ret = Request.Browser.IsMobileDevice;
            string userAgent = Request.UserAgent;

            if (!ret)
            {
                // Use regular expression
                Regex b = new Regex(@"(android|bb\d+|meego)
                                    .+mobile|avantgo|bada\/|blackberry|
                                    blazer|compal|elaine|fennec|hiptop|
                                    iemobile|ip(hone|od)|iris|kindle|lge
                                    |maemo|midp|mmp|mobile.+firefox|
                                    netfront|opera m(ob|in)i|palm(os)
                                    ?|phone|p(ixi|re)\/|plucker|
                                    pocket|psp|series(4|6)0|symbian|
                                    treo|up\.(browser|link)|vodafone|
                                    wap|windows ce|xda|xiino",
                  RegexOptions.IgnoreCase |
                  RegexOptions.Multiline);

                ret = b.IsMatch(userAgent);

                // Check user agent for certain words
                ret = !ret
                        ? userAgent.ToLower().Contains("iphone")
                        : true;
                ret = !ret
                        ? userAgent.ToLower().Contains("android")
                        : true;
                // etc.
            }
            return ret;
        }
    }
            
  
}
