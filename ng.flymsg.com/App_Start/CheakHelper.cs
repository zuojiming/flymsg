using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace ng.flymsg.com
{
    public static class CheakHelper
    {
        public static bool CheckChinese(string str)
        {
            bool flag = false;
            UnicodeEncoding a = new UnicodeEncoding();
            byte[] b = a.GetBytes(str);
            for (int i = 0; i < b.Length; i++)
            {
                i++;
                if (b[i] != 0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}