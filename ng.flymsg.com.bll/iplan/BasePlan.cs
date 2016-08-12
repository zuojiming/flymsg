using ng.flymsg.com.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll
{
    public abstract class BasePlan : IMsgAction<string>
    {
        public abstract Dictionary<string, string> bodyParams { get; set; }

        public abstract string temp { get; set; }

        public abstract string DoAction();
    }
}
