using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class TagSymbFactory
    {
        private static Dictionary<string, TagSymb> Tags = new Dictionary<string, TagSymb>();
        public static TagSymb GetTag(string name, string displayType, bool closingtype)
        {
            var tagSymb = Tags.GetValueOrDefault(name);
            if (tagSymb == null)
            {
                tagSymb = new TagSymb(name, displayType, closingtype);
                Tags.Add(name, tagSymb);
            }
            return tagSymb;
        }
    }
}
