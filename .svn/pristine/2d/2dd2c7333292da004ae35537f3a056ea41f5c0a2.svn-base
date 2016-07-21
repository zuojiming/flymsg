using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using www.flymsg.com.Model;
using www.flymsg.com.bll;

namespace www.flymsg.com.Areas.DataFormat.Controllers
{
    public class BasicConvertController : Controller
    {
        public ActionResult Index(ConvertOperation c)
        {
            if (c == null || (c!=null && c.ResultContent == null && c.SourceContent == null))
            {
                c = new ConvertOperation();
                c.SourceContent = "";
                c.ResultContent = "";
            }
            if (!string.IsNullOrEmpty(c.SourceTypeStr) && !string.IsNullOrEmpty(c.ResultTypeStr))
            {
                if ((c.SourceContent as string[]) != null)
                    c.SourceContent = ((string[])c.SourceContent)[0];
                WFCEncodingFormatConvertBLL_ wfc = new WFCEncodingFormatConvertBLL_();
                c.ResultContent = wfc.DoConvert(wfc.GetBase(c.SourceContent.ToString(), c.SourceTypeStr, c.ResultTypeStr), c.ResultTypeStr);
            }
            return View(c);
        }

        public ActionResult TextArea(string s,string e) {
            if (string.IsNullOrEmpty(e))
                e = System.Text.Encoding.Default.WebName;
            if (string.IsNullOrEmpty(s))
                s = "";
            ViewBag.str = s;
            System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.GetEncoding(e);
            return View();
        }
    }
}