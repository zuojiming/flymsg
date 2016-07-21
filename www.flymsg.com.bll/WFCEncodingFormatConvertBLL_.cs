using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.flymsg.com.Model;
using www.flymsg.com.ibll;

namespace www.flymsg.com.bll
{
    public class WFCEncodingFormatConvertBLL_ : IEFConverter
    {
        public string DoConvert(object b, params string[] arrs)
        {
            byte[] bs = (byte[])b;
            string s = Encoding.GetEncoding(arrs[0]).GetString(bs);
            return s;
        }

        public object GetBase(string m, params string[] arrs)
        {
            Encoding s = Encoding.GetEncoding(arrs[0]),r = Encoding.GetEncoding(arrs[1]);
            byte[] bs = Encoding.Convert(s,r,s.GetBytes(m));
            return bs;
        }
    }
}
