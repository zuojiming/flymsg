using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace ng.flymsg.com
{
    public static class HelperCommand
    {
        public static string Image(this UrlHelper url,string name) {
            return "/Content/Images/" + name;
        }

        public static XDocument AppXML(this HtmlHelper html)
        {
            var doc = XDocument.Load(System.Web.HttpContext.Current.Server.MapPath("/Content/ConMenu.xml"));
            return doc;
        }
    }
}