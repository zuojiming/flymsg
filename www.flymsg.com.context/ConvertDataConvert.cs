using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.flymsg.com.Model;

namespace www.flymsg.com.context
{
    public class ConvertDataConvert : DbContext
    {
        public ConvertDataConvert() :
            base("name=ConvertOperation")
        {

        }

        public virtual DbSet<ConvertData> ConvertDatas { get; set; }
    }
}
