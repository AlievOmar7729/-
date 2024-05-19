using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Command
{
public class AddNodeCommand : ICommand
    {
        private readonly ILightNode _parent;
        private readonly ILightNode _child;

        public AddNodeCommand(ILightNode parent, ILightNode child)
        {
            _parent = parent;
            _child = child;
        }

        public void Execute()
        {
            if (_parent is LightElementNode elementNode)
            {
                elementNode.AddChildren(_child);
            }
        }

        public void Undo()
        {
            if (_parent is LightElementNode elementNode)
            {
                elementNode.RemoveChildren(_child);
            }
        }
    }

}
