using ng.flymsg.com.bll.iplan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.plans
{
    public class PlanCreater : CreaterBase<BasePlan>
    {
        /// <summary>
        /// throw a not impl exception
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BasePlan Create()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// throw a not impl exception
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BasePlan Create(List<object> obj)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// throw a not impl exception
        /// </summary>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BasePlan Create(params bool[] b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// throw a not impl exception
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BasePlan Create(params int[] val)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// this function return a val of Plans
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public BasePlan Create(params string[] str)
        {
            Encoding source = Encoding.GetEncoding(str[0]);
            Encoding target = Encoding.GetEncoding(str[1]);
            BasePlan result = null;
            if (source == Encoding.GetEncoding("GB2312") && target == Encoding.UTF8)
            {
                result = new Str_To_Int();
                result.bodyParams = new Dictionary<string, string>
                {
                    ["prepend"] = "&#x",
                    ["append"] = ";"
                };
            }
            else if (source == Encoding.GetEncoding("GB2312") && target == Encoding.UTF8)
            {
                result = new Str_To_Int();
                result.bodyParams = new Dictionary<string, string>
                {
                    ["prepend"] = "\\u",
                    ["append"] = ""
                };
            }
            else if (System_Function.SYS_FUNC_NAME.Contains(str[0]))
            {
                var sys_func = new System_Function();
                sys_func.bodyParams = str.ToDictionary(k => "p" + str.ToList().IndexOf(k), v => v);
                result = sys_func;
            }
            else if (Code_Convert.CONVERT_FLAG.Contains(str[0]))
            {
                var sys_func = new Code_Convert();
                sys_func.bodyParams = str.ToDictionary(k => "p" + str.ToList().IndexOf(k), v => v);
                result = sys_func;
            }
            else {
                result = new PlanUser_Custome();
            }
            result.temp = str[str.Length - 1];
            return result;
        }
    }
}
