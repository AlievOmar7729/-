using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
    public class BaseComponent
    {
        public CommandCentre? commandCentre;
        
        protected  void _notifyCommand(string ev)
        {
            if (commandCentre != null)
            {
                this.commandCentre.Notify(ev);
            }
        }

    }
}
