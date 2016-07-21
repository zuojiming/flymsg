using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.flymsg.com.Model;

namespace www.flymsg.com.ibll
{
    public interface IBaseConvert<T>
    {
        T DoConvert(object b,params string[] arrs);
        object GetBase(T m, params string[] arrs);
    }
}
