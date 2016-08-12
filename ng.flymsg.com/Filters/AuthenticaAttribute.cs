using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ng.flymsg.com.Filters
{
    public class AuthenticaAttribute : ActionFilterAttribute
    {
        public bool IsCheck { get; set; } = true;

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (IsCheck && HttpContext.Current.Session["User"] == null)
                HttpContext.Current.Response.Redirect("http://www.baidu.com");
            base.OnResultExecuting(filterContext);
        }
    }
}
