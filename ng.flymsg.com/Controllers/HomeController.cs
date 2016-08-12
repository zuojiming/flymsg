using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using ng.flymsg.com;
using System.Text;
using ng.flymsg.com.IBLL;
using ng.flymsg.com.bll;
using ng.flymsg.com.bll.plans;
using ng.flymsg.com.bll.iplan;
using ng.flymsg.com.Filters;

namespace ng.flymsg.com.Controllers
{
    [Authentica]
    public class HomeController : Controller
    {
        public CreaterBase<BasePlan> QueryerCreater
        {
            get
            {
                return new PlanCreater();
            }
        }

        [Authentica(IsCheck =false)]
        public ActionResult Index()
        {
            BasePlan action = new PlanUser_Custome();
            action.temp = @"\$name\$ is $name$";
            action.bodyParams = new Dictionary<string, string> {
                ["name"] = "zuoqi"
            };
            string val = action.DoAction();

            return View();
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
        [HttpPost]
        public JsonResult NavbarTitles() {
            
            var result = new
            {
                result = new List<object> {
                    new {
                        title = "",
                        name = "",
                        items = new object[]{ }
                    }
                },
                status = new StringBuilder("error")
            };
            
            try
            {
                var doc = HelperCommand.AppXML(null);
                var parent_eles = doc.Element("root").Elements();
                Dictionary<string, IEnumerable<XElement>> in_eles = new Dictionary<string, IEnumerable<XElement>>();
                //result.result.Concat();
                var eles = parent_eles.Select(ps => new
                {
                    title = ps.Attribute("title").Value,
                    name = ps.Attribute("name").Value,
                    items = ps.Elements().Select(item => new
                    {
                        @class = item.Attribute("class").Value,
                        method = item.Attribute("method").Value,
                        controller = item.Attribute("controller").Value,
                        con = item.Attribute("con").Value,
                        text = item.Value
                    })
                }).ToArray();
                result.result.AddRange(eles);
                result.status.Clear();
                result.status.Append("success");
            }
            catch (Exception)
            { }

            return Json(result);
        }
    }
}