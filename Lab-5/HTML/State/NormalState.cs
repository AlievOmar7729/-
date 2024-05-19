using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.State
{
    internal class NormalState : IState
    {
        public void Handle(LightElementNode element)
        {
            element.CssClasses.Remove("hover");
        }
    }
}
