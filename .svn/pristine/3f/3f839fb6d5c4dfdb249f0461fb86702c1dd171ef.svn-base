using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace www.flymsg.com.Common
{
    public class ConvertHelper
    {
        public string BytesToUTF8(byte[] bs) {
            return System.Text.Encoding.UTF8.GetString(bs);
        }

        public string BytesToUTF7(byte[] bs)
        {
            return System.Text.Encoding.UTF7.GetString(bs);
        }

        public string BytesToUTF32(byte[] bs)
        {
            return System.Text.Encoding.UTF32.GetString(bs);
        }

        public byte[] UTF8ToByte(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        public byte[] UTF7ToByte(string str)
        {
            return System.Text.Encoding.UTF7.GetBytes(str);
        }

        public byte[] UTF32ToByte(string str)
        {
            return System.Text.Encoding.UTF8.GetBytes(str);
        }

        public string BytesToUnicode(byte[] bs)
        {
            return System.Text.Encoding.Unicode.GetString(bs);
        }

        public byte[] UnicodeToByte(string str)
        {
            return System.Text.Encoding.Unicode.GetBytes(str);
        }

        public string BytesToASCII(byte[] bs)
        {
            return System.Text.Encoding.ASCII.GetString(bs);
        }

        public byte[] ASCIIToByte(string str)
        {
            return System.Text.Encoding.ASCII.GetBytes(str);
        }

        public string BytesToGB2312(byte[] bs)
        {
            return System.Text.Encoding.GetEncoding("GB2312").GetString(bs);
        }

        public byte[] GB2312ToByte(string str)
        {
            return System.Text.Encoding.GetEncoding("GB2312").GetBytes(str);
        }

        public string BytesToEncoding(byte[] bs,string et)
        {
            return System.Text.Encoding.GetEncoding(et).GetString(bs);
        }

        public byte[] EncodingToByte(string str, string et)
        {
            return System.Text.Encoding.GetEncoding(et).GetBytes(str);
        }
    }
}
