
using Builder;

IBuilderCharacter builderCharacterAltair = new HeroBuilder("Altair");
CharacterDirector heroDirector = new CharacterDirector(builderCharacterAltair);
Character altair = heroDirector.CreateCharacter();

altair = builderCharacterAltair.SetHeight(178)
                         .SetBuild("Athletic")
                         .SetHairColor("Black")
                         .SetEyeColor("Green")
                         .SetClothing("Mantle")
                         .SetInventory("Blade")
                         .SetInventory("Piece of Eden")
                         .SetInventory("Hand crossbow")
                         .SetInventory("Сoin denomination 50")
                         .SetInventory("Сoin denomination 50")
                         .SetInventory("Сoin denomination 50")
                         .SetInventory("Piece of Eden")
                         .SetGood(true)
                         .AddGoodDeed("Saved a people from the death penalty")
                         .Build();
altair.ShowDetails();

IBuilderCharacter builderCharacterTemplar = new EnemyBuilder("Templar");
CharacterDirector enemyDirector = new CharacterDirector(builderCharacterTemplar);
Character templar = enemyDirector.CreateCharacter();

templar = builderCharacterTemplar.SetHeight(182)
                         .SetBuild("Athletic")
                         .SetHairColor("Black")
                         .SetEyeColor("Brown")
                         .SetClothing("Armor")
                         .SetInventory("Sword")
                         .SetInventory("Shield")
                         .SetInventory("Smoke grenade")
                         .SetInventory("Сoin denomination 5")
                         .SetInventory("Сoin denomination 5")
                         .SetInventory("Сoin denomination 10")
                         .SetGood(false)
                         .AddEvilDeed("Executed an innocent man")
                         .Build();
templar.ShowDetails();
