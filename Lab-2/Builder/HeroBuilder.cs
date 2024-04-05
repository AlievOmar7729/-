namespace Builder
{
    class HeroBuilder : IBuilderCharacter
    {
        private Character character;

        public HeroBuilder(string name)
        {
            character = new Character();
            character.Name = name;
            character.GoodDeeds = new List<string>();
            character.EvilDeeds = new List<string>();
            character.Inventory = new List<string>();
        }

        public IBuilderCharacter SetHeight(int height)
        {
            character.Height = height;
            return this;
        }
        public IBuilderCharacter SetBuild(string build)
        {
            character.Build = build;
            return this;
        }
        public IBuilderCharacter SetHairColor(string hairColor)
        {
            character.HairColor = hairColor;
            return this;
        }
        public IBuilderCharacter SetEyeColor(string eyeColor)
        {
            character.EyeColor = eyeColor;
            return this;
        }
        public IBuilderCharacter SetClothing(string clothing)
        {
            character.Clothing = clothing;
            return this;
        }
        public IBuilderCharacter SetInventory(string inventory)
        {
            character.Inventory.Add(inventory);
            return this;
        }
        public IBuilderCharacter SetGood(bool isGood)
        {
            character.IsGood = isGood;
            return this;
        }
        public IBuilderCharacter AddGoodDeed(string affairs)
        {
            character.GoodDeeds.Add(affairs);
            return this;
        }
        public IBuilderCharacter AddEvilDeed(string affairs)
        {
            character.EvilDeeds.Add(affairs);
            return this;
        }
        public Character Build()
        {
            return character;
        }
    }
}
