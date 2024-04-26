using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Sledgehammer : Artifact
    {
        public Sledgehammer(Hero hero) : base(hero) { }

        public override int GetHit()
        {
            return _hero.GetHit() + 150;
        }

        public override int GetProtection()
        {
            return _hero.GetProtection();
        }

        public override int GetSpeed()
        {
            return _hero.GetSpeed() - 20;
        }
    }
}
