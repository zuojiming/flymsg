using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.bll.iplan
{
    public interface CreaterBase<T>
    {
        T Create();
        T Create(params string[] str);
        T Create(params int[] val);
        T Create(params bool[] b);
        T Create(List<object> obj);
    }
}
