using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IBuilderCharacter
    {
        IBuilderCharacter SetHeight(int height);
        IBuilderCharacter SetBuild(string build);
        IBuilderCharacter SetHairColor(string hairColor);
        IBuilderCharacter SetEyeColor(string eyeColor);
        IBuilderCharacter SetClothing(string clothing);
        IBuilderCharacter SetInventory(string inventory);
        IBuilderCharacter SetGood(bool isGood);
        IBuilderCharacter AddGoodDeed(string deed);
        IBuilderCharacter AddEvilDeed(string deed);
        Character Build();
    }
}
