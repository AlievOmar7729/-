using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LightElementNodeFlyweight : ILightNode
    {
        protected List<ILightNode> _children = new List<ILightNode>();
        protected TagSymb tagSymb;
        public List<string> CssClasses { get; set; }

        public LightElementNodeFlyweight(string tag,string displayType,bool closingType)
        {
            CssClasses = new List<string>();
            tagSymb = TagSymbFactory.getTag(tag, displayType, closingType);
        }
        public void AddChildren(ILightNode node)
        {
            _children.Add(node);
        }
        public void RemoveChildren(ILightNode node)
        {
            _children.Remove(node);
        }

        public void innerHTML()
        {
            foreach (var node in _children)
            {
                node.outerHTML();
            }
        }
        public void outerHTML()
        {
            if (CssClasses.Count == 0)
            {
                Console.WriteLine($"<{tagSymb.Tag}>");
            }
            else
            {
                Console.WriteLine($"<{tagSymb.Tag} class=\"{string.Join(" ", CssClasses)}\">");
            }

            innerHTML();
            if (tagSymb.DisplayType == "block")
            {
                Console.WriteLine($"</{tagSymb.Tag}{(tagSymb.ClosingType == true ? ">" : " />")}");
            }
        }
    }
}
