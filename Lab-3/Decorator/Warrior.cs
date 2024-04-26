using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Hit = 70;
            Protection = 250;
            Speed = 60;
        }
        public override int GetHit()
        {
            return Hit;
        }
        public override int GetProtection()
        {
            return Protection;
        }
        public override int GetSpeed()
        {
            return Speed;
        }

    }
}
