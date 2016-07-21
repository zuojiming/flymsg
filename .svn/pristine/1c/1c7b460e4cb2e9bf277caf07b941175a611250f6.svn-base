using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using www.flymsg.com.Model;

namespace www.flymsg.com.context
{
    /// <summary>
    /// 数据转换操作
    /// </summary>
    public class ConvertOperationContext : DbContext
    {
        public ConvertOperationContext()
           : base("name=ConvertOperation")
        {
        }

        public virtual DbSet<ConvertOperation> ConvertOperations { get; set; }
    }
}
