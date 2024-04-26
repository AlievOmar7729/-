using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class SpeedBoots : Artifact
    {
        public SpeedBoots(Hero hero) : base(hero)
        {
        }

        public override int GetHit()
        {
            return _hero.GetHit();
        }

        public override int GetProtection()
        {
            return _hero.GetProtection() + 10;
        }

        public override int GetSpeed()
        {
            return _hero.GetSpeed() + 100;
        }
    }
}
