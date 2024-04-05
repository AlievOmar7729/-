using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Character
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; }
        public bool IsGood { get; set; }
        public List<string> GoodDeeds { get; set; }
        public List<string> EvilDeeds { get; set; }


        public void ShowDetails()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height} cm");
            Console.WriteLine($"Build: {Build}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            DisplayInventory(Inventory);
            Console.WriteLine($"Alignment: {(IsGood ? "Good" : "Evil")}");
            Console.WriteLine("Good Deeds:");
            foreach (var affairs in GoodDeeds)
            {
                Console.WriteLine($"- {affairs}");
            }
            Console.WriteLine("Evil Deeds:");
            foreach (var affairs in EvilDeeds)
            {
                Console.WriteLine($"- {affairs}");
            }
            Console.WriteLine("----------------------");
        }

        private void DisplayInventory(List<string> inventory)
        {
            var groupedItems = inventory.GroupBy(x => x).Select(g => new { Item = g.Key, Count = g.Count() });
            Console.WriteLine("Inventory:");
            foreach (var item in groupedItems)
            {
                Console.WriteLine($"{item.Count}x - \"{item.Item}\"");
            }
        }
    }
}
