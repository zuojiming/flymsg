using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace ng.flymsg.com.App_Start
{
    public static class ConvertHelper
    {
        public static bool Check(string input) {
            string _ = input;
            bool bl = string.IsNullOrWhiteSpace(_) ? true : _.Any(any => Regex.IsMatch(any.ToString(), @"[\u4e00-\u9fa5]+$"));
            return bl;
        }

        /// <summary>
        /// 字符转化
        /// </summary>
        /// <param name="input">要转化的字符</param>
        /// <param name="con">原编码</param>
        /// <param name="parse">要转换的编码</param>
        /// <returns></returns>
        public static string Convert(string input, string con = "auto",string parse = "auto")
        {
            bool isChinese =true;
            //所有编码格式
            string[] encodings = {
                "GB2312","ASCII","Unicode","UTF-8"
            };
            //原编码筛选
            string[] srcEdgs = con != "auto" ? encodings.Where(w => w.ToLower() == con.ToLower()).ToArray() : encodings;
            //目标编码筛选
            string[] parseEdgs = parse != "auto" ? encodings.Where(w => w.ToLower() == parse.ToLower()).ToArray() : encodings;
            //转换编码变量
            Encoding srcEdg = Encoding.Default,pEdg = Encoding.Default;
            byte[] strBytes = { };
            //是否中文检测
            
            //如果不是中文，那么就是编码转汉字
            if (!string.IsNullOrWhiteSpace(input))//Check(input)
            {
                //string[] c = parseEdgs.ToArray();
                //parseEdgs = srcEdgs.ToArray();
                //srcEdgs = c.ToArray();
                //isChinese = false;
                foreach (var item in srcEdgs)
                {
                    Encoding pEng = Encoding.GetEncoding(parseEdgs.First()),sEng = Encoding.GetEncoding(item);
                    //input = string.Join("", input.Select(s => HttpUtility.UrlDecode(s.ToString(), Encoding.GetEncoding(item))).ToArray());
                    strBytes = Encoding.Convert(sEng, pEng, sEng.GetBytes(input));

                    string s = "大西瓜";
                    string code = "";
                    foreach (byte b in Encoding.UTF8.GetBytes(s))
                    {
                        code += '%' + b.ToString("X");
                    }
                    Console.WriteLine(code);

                    input = pEng.GetString(strBytes);
                    //cEng.GetString();
                    //if (Check(input))
                    return input;
                }
            }
            strBytes = Encoding.GetEncoding(srcEdgs[0]).GetBytes(input);
            //转换方法
            for (int index = 0; index < srcEdgs.Length && !Check(srcEdg.GetString(strBytes)); index++)
            {
                var item = srcEdgs[index];
                srcEdg = Encoding.GetEncoding(item);
                strBytes = srcEdg.GetBytes(input);
            }
            strBytes = Encoding.GetEncoding(parseEdgs[0]).GetBytes(input);
            for (int parseIdx = 0; parseIdx < parseEdgs.Length && !Check(strBytes == null ? "" :pEdg.GetString(strBytes)); parseIdx++)
            {
                var pitem = parseEdgs[parseIdx];
                pEdg = Encoding.GetEncoding(pitem);
                strBytes = pEdg.GetBytes(input);
            }
            return HttpUtility.UrlEncode(strBytes);
        }

        public static string NativeGB2312Convert(string input) {
            if (Check(input)) {
                return HttpUtility.UrlEncode(input);
            }
            return HttpUtility.UrlDecode(input);
        }

        public static string NativeASCIIConvert(string input)
        {
            bool sASC = Check(HttpUtility.UrlDecode(input, Encoding.ASCII));
            if (sASC)
            {
                input = HttpUtility.UrlDecode(input,Encoding.ASCII);
                return HttpUtility.UrlEncode(input);
            }
            input = HttpUtility.HtmlDecode(input);
            return HttpUtility.UrlEncode(Encoding.ASCII.GetBytes(input));
        }
    }
}
