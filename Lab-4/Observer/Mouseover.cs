using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Mouseove : IEventListener
    {
        public void Event()
        {
            Console.WriteLine("Mouseove!");
        }
    }
}
