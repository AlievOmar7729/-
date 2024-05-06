using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
    public class Aircraft : BaseComponent
    {
        public string Name;
        public Guid CurrentRunway{get;set;}
        public bool IsTakingOff { get;set;} 
        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void Land()
        {
            Console.WriteLine($"Aircraft {this.Name} is landing");
            this._notifyCommand("Land");
        }
        public void TakeOff()
        {
            Console.WriteLine($"Aircraft {this.Name} is taking off");
            this._notifyCommand("TakeOff");
        }
    }
}
