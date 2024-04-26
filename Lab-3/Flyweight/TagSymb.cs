using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TagSymb
    {
        public string Tag { get; }
        public string DisplayType { get; }
        public bool ClosingType { get; }
        public TagSymb(string tag, string displayType, bool closingtype)
        {
            this.Tag = tag;
            this.DisplayType = displayType;
            this.ClosingType = closingtype;
        }
    }
}
