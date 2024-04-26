using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightElementNode : ILightNode
    {
        protected List<ILightNode> _children = new List<ILightNode>();
        public string Tag { get; set; }
        public string DisplayType { get; set; }
        public bool ClosingType { get; set; }
        public List<string> CssClasses { get; set; }

        public LightElementNode()
        {
            _children = new List<ILightNode>();
            CssClasses = new List<string>();
            Tag = "div";
            DisplayType = "block";
            ClosingType = true;
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
                Console.WriteLine($"<{Tag}>");
            }
            else
            {
                Console.WriteLine($"<{Tag} class=\"{string.Join(" ", CssClasses)}\">");
            }

            innerHTML();
            if (DisplayType == "block")
            {
                Console.WriteLine($"</{Tag}{(ClosingType == true ? ">" : " />")}");
            }
        }
    }
}
