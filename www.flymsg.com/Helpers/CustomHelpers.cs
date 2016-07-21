using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace www.flymsg.com.Helpers
{
    public static class CustomHelpers
    {
        public static MvcHtmlString EnumRadioListFor<TModel, TEnum>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TEnum>> expression)
        {
            var files = expression.Body.Type.GetFields(BindingFlags.Public | BindingFlags.Static);
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul style='list-style:none;'>");
            foreach (var item in files)
            {
                string eleId = Guid.NewGuid().ToString();
                sb.Append("<li style='list-style:none;"+(item == files.Last() ? "": " float:left;") +"' >");
                sb.Append("<input type='radio' name='" + expression.Body.Type.Name + "' value='" + Convert.ToInt32(item.GetValue(null)) + "' id='" + eleId + "' />");
                sb.Append("<label for='" + eleId + @"' > " + item.Name + @" </label>");
                sb.Append("</li>");
            }
            sb.Append("</ul>");
            return MvcHtmlString.Create(sb.ToString());
        }

        public static MvcHtmlString FileSaveFor(this HtmlHelper htmlHelper, string name, string value)
        {
            bool isHtml = value.ToLower().IndexOf("http://") >= 0;

            StringBuilder sb = new StringBuilder();
            sb.Append("<div>");
            sb.AppendFormat("<input type='radio' value='local' id='" + name + "_rl' name='" + name + "_r' {0} /><label name='" + name + "_r' for='" + name + "_rl'>选择本地文件</label>", !isHtml ? "checked='checked'" : "");
            sb.AppendFormat("<input type='radio' value='local' id='" + name + "_rw' name='" + name + "_r' {0} /><label name='" + name + "_r' for='" + name + "_rw'>选择网络文件</label>", isHtml ? "checked='checked'" : "");
            sb.AppendFormat("<input type='file' name='" + name + "_t' id='" + name + "_l' {0}/>", !isHtml ? "style='display:none;'" : "");
            sb.AppendFormat("<input type='text' name='" + name + "_t' id='" + name + "_w' {0} value='{1}' />", isHtml ? "" : "style='display:none;'", isHtml ? value : "");
            sb.Append("<input type='hidden' name='" + name + "' id='" + name + "' />");
            sb.Append("<script type='text/javascript'>");
            sb.Append("$(function () {");
            sb.Append("    //alert($('#" + name + "_rl,#" + name + "_rw').length)");
            sb.Append("   $('[name=" + name + "_t]').bind('input change', function () {");
            sb.Append("        $('#" + name + "').val($(this).val());");
            sb.Append("   });");
            sb.Append("   $('[name=" + name + "_r]').click(function () {");
            sb.Append("        $(this).closest('div').find('input').each(function (i,val) {");
            sb.Append("           $(this).val('');");
            sb.Append("      });");
            sb.Append("       $('[name=" + name + "_t]').hide();");
            sb.Append("      $('#' + this.id.replace('_r', '_')).show();");
            sb.Append("   });");
            sb.Append(" });");
            sb.Append(" </script>");
            sb.Append("</div>");
            return MvcHtmlString.Create(sb.ToString());
        }
    }
}