using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.IBLL
{
    public interface IMsgAction<T>
    {
        Dictionary<string,T> bodyParams { get; set;}
        T temp { get; set; }
        T DoAction();
    }

    public enum ActionType { }
}
