using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Visitor
{
    public class ElementCountVisitor : ILightNodeVisitor
    {
        public int ElementCount { get; private set; }
        public int TextCount { get; private set; }

        public void Visit(LightElementNode elementNode)
        {
            ElementCount++;
            foreach (var child in elementNode.GetChildren())
            {
                child.Accept(this);
            }
        }

        public void Visit(LightTextNode textNode)
        {
            TextCount++;
        }
    }
}
