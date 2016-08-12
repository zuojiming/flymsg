using ng.flymsg.com.bll.iplan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.impl
{
    public class TemplateModel : BaseModel
    {
        public int Id { get; set; } = 0;
        public string Code { get; set; } = "0000";
        public string Temp { get; set; } = string.Empty;
        public PlanType PlanType { get; set; } = PlanType.PlanUser_Custome;
        public string IsPublic { get; set; } = "0";
        public decimal Price { get; set; } = 0;
        public string Desc { get; set; } = string.Empty;
        public BasePlan Plan => System.Reflection.Assembly.GetExecutingAssembly().CreateInstance("ng.flymsg.com.bll.plans" + this.PlanType.ToString(), false) as BasePlan;
    }
}
