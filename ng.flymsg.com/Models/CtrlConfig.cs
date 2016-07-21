using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ng.flymsg.com.Models
{
    [Serializable]
    public class CtrlSub {
        public CtrlConfig Nav { get; set; }
        public CtrlItem Item { get; set; }
    }

    [Serializable]
    public class CtrlConfig
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Tip { get; set; }
        public List<CtrlItem> items { get; set; }
    }

    [Serializable]
    public class CtrlItem
    {
        public string @Class { get; set; }
        public string Method { get; set; }
        public string Controller { get; set; }
        public string Con { get; set; }
    }
}
