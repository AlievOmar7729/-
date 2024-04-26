using Decorator;

Hero DragonKnight = new Warrior();
DragonKnight = new SpeedBoots(DragonKnight);
DragonKnight = new CloakSpike(DragonKnight);
Console.Write($"Hit DK: {DragonKnight.GetHit()} |");
Console.Write($"Protection DK: {DragonKnight.GetProtection()} |");
Console.Write($"Speed DK: {DragonKnight.GetSpeed()}  |");
Hero test = new Palladin();
test = new CloakSpike(test);
