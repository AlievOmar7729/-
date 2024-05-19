using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.State
{
    internal class HoverState : IState
    {
        public void Handle(LightElementNode element)
        {
            if (!element.CssClasses.Contains("hover"))
            {
                element.CssClasses.Add("hover");
            }
        }
    }
}
