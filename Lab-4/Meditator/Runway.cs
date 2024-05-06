using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
    public class Runway : BaseComponent
    {
        public readonly Guid Id  = Guid.NewGuid();
        public bool IsBusyWithAircraft { get; set; } = false;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }

    }
}
