using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Hero
    {
        public int Hit { get; set; }
        public int Protection { get; set; }
        public int Speed { get; set; }

        public abstract int GetHit();
        public abstract int GetProtection();
        public abstract int GetSpeed();
    }
}
