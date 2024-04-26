using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CloakSpike : Artifact
    {

        public CloakSpike(Hero hero) : base(hero) { }

        public override int GetHit()
        {
            return _hero.GetHit() + 10;
        }
        public override int GetProtection()
        {
            return _hero.GetProtection() + 55;
        }

        public override int GetSpeed()
        {
            return _hero.GetSpeed() + 40;
        }
    }
}
