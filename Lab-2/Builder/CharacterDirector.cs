using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CharacterDirector
    {
        private readonly IBuilderCharacter _builder;

        public CharacterDirector(IBuilderCharacter builder)
        {
            _builder = builder;
        }

        public Character CreateCharacter()
        {
            return _builder.Build();

        }
    }
}
