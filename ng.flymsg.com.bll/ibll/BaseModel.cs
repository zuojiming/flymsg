using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll
{
    public class BaseModel
    {
        public int CreateUser { get; set; } = 0;
        public int LastModifyUser { get; set; } = 0;
        public DateTime CreateTime { get; set; } = DateTime.Now;
        public DateTime LastModifyTime { get; set; } = DateTime.Now;
    }
}
