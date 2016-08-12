using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.plans
{
    public class System_Function : BasePlan
    {
        public static List<string> SYS_FUNC_NAME => new List<string>()
        {
            "getDate","IDEntity","Replace","CharIndex","SubString","Floor","CEILING","Exists"
        };
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
            return "";
        }
    }
}
