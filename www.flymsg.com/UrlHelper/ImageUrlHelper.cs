using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace www.flymsg.com.UrlHelper
{
    public static class ImageUrlHelper
    {
        public static string Image(this System.Web.Mvc.UrlHelper url,string imageName,string folder="") {
            string imageUrl = "/Content/images/" + folder +"/"+ imageName;
            while (imageUrl.IndexOf("//") >= 0)
                imageUrl = imageUrl.Replace("//", "/");
            return imageUrl;
        }
    }
}