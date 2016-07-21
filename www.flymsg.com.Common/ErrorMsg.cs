using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.flymsg.com.Common
{
    public static class ErrorNum
    {
        public const int USERNUM = 10000;       //用户错误父码
        public const int NETLINENUM = 20000;    //网络错误父码
        public const int APPERRORNUM = 30000;   //系统错误父码
    }
    public enum ErrorMsg {
        用户名或密码错误=ErrorNum.USERNUM + 1,
        网络连接失败 = ErrorNum.NETLINENUM + 1,
        系统未知错误 = ErrorNum.APPERRORNUM + 1
    }
    public class ErrorHelper {
        public string GetError(int code) {
            return ((ErrorMsg)code).ToString();
        }
    }
}
