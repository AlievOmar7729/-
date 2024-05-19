using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.State
{
    public interface IState
    {
        void Handle(LightElementNode element);
    }
}
