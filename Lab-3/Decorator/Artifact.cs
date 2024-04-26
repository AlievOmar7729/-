using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Artifact : Hero
    {
        protected Hero _hero;

        public Artifact(Hero hero)
        {
            _hero = hero;
        }
    }
}
