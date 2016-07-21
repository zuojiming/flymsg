using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using www.flymsg.com.bll;
using www.flymsg.com.Model;

namespace www.flymsg.com.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(ConvertOperation m)
        {
            System.Web.HttpContext.Current.Response.Redirect("/DataFormat/BasicConvert/Index");
            return View();
        }

        [ActionName("Index"),HttpPost]
        public ActionResult IndexForm(ConvertOperation m) {
            return View(m);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}