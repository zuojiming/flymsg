using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ng.flymsg.com.Controllers
{
    public class FormaterController : Controller
    {
        // GET: Formater
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(dynamic d) {
            return View();
        }
    }
}