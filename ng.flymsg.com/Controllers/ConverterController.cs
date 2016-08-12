using ng.flymsg.com.App_Start;
using ng.flymsg.com.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ng.flymsg.com.Controllers
{
    public class ConverterController : Controller
    {
        // GET: Converter
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost,ValidateInput(false)]
        public string Index(string data)
        {
            CtrlItem ctrlItem = new CtrlItem();
            foreach (PropertyInfo proitem in typeof(CtrlItem).GetProperties())
            {
                proitem.SetValue(ctrlItem, Request.Form["ctrl[" + proitem.Name + "]"]);
            }
            string sedg = "auto", pedg = "auto";
            string[] cons = ctrlItem.Con.Split(';');
            if (cons.Length > 1)
            {
                sedg = cons[0];
                pedg = cons[1];
            }

            return ConvertHelper.Convert(data, sedg, pedg);
        }

        [HttpPost, ValidateInput(false)]
        public string NativeGB2312Convert(string data) {
             return ConvertHelper.NativeGB2312Convert(data);
        }

        [HttpPost, ValidateInput(false)]
        public string NativeASCIIConvert(string data)
        {
            return ConvertHelper.NativeASCIIConvert(data);
        }

        [Authorize]
        public string CheckSysFuncExists() {
            return "zuoqi";
        }
    }
}