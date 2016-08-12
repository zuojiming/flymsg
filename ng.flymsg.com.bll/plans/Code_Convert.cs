using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.plans
{
    public class Code_Convert : BasePlan
    {
        public static List<string> CONVERT_FLAG { get; } = new List<string>() {
            "Convert"
        };
        /// <summary>
        /// 'source' is source encoding,'target' is target encoding
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
            Encoding sourceEncoding = Encoding.GetEncoding(bodyParams["source"]);
            Encoding targetEncoding = Encoding.GetEncoding(bodyParams["source"]);
            byte[] sourceBytes = sourceEncoding.GetBytes(temp);
            byte[] convertBytes = Encoding.Convert(sourceEncoding,targetEncoding,sourceBytes);
            string result = targetEncoding.GetString(convertBytes);
            return result;
        }
    }
}
