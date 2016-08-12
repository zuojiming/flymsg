using ng.flymsg.com.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.plans
{
    public class PlanUser_Custome : BasePlan
    {
        public override Dictionary<string, string> bodyParams
        {
            get; set;
        }

        public override string temp
        {
            get;set;
        }

        public override string DoAction() {
            temp = temp.Replace(@"\$",@"(\$)");
            foreach (var pitem in bodyParams)
            {
                Regex regex = new Regex(@"$\w+$");
                temp = temp.Replace($"${pitem.Key}$", pitem.Value.ToString());
            }
            temp = temp.Replace(@"(\$)","$");
            return temp;
        }
    }
}
