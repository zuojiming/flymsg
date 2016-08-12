using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.plans
{
    public class Str_To_Int : BasePlan
    {
        /// <summary>
        /// prepend is insert string for zero index,append is insert string for last index
        /// </summary>
        /// <value>
        /// The body parameters.
        /// </value>
        public override Dictionary<string, string> bodyParams
        {
            get;set;
        }

        public override string temp
        {
            get;set;
        }

        public override string DoAction()
        {
            var result = string.Join("", temp.Select(c => bodyParams["prepend"] +
                        Encoding.Unicode.GetBytes(c.ToString())[1].ToString("X2") +
                        Encoding.Unicode.GetBytes(c.ToString())[0].ToString("X2") + bodyParams["append"]).ToArray());
            return result;
        }
    }
}
