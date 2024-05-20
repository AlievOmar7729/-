using HTML.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Deafault
{
    public interface ILightNode
    {
        public void outerHTML();
        public void innerHTML();

        void Accept(ILightNodeVisitor visitor);
    }
}
