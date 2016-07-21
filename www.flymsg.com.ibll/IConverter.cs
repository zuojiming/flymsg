using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using www.flymsg.com.ibll;
using www.flymsg.com.Model;

namespace www.flymsg.com.ibll
{
    public interface IConverter<T> : IBaseConvert<T> where T : ConvertOperation
    {

    }

    public interface IEFConverter: IBaseConvert<string>
    {

    }
}
