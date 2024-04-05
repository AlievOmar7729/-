using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype 
{
    public class Virus : ICloneable
    {
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }



        public Virus(double weight, int age, string name, string type)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children = new List<Virus>();
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void PrintDetails(string pref = "")
        {
            Console.WriteLine($"{pref}Name: {Name}, Weight: {Weight}, Age: {Age}, Type: {Type}");
            foreach (var child in Children)
            {
                child.PrintDetails(pref + "  ");
            }
        }

    }


}
