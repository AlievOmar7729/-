using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Visitor
{
    public interface ILightNodeVisitor
    {
        void Visit(LightElementNode elementNode);
        void Visit(LightTextNode textNode);
    }
}
