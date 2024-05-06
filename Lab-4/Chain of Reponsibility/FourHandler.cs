using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Reponsibility
{
    public class FourHandler : Handler
    {
        public override void Handle(int choice)
        {
            if (choice == 4)
            {
                Console.WriteLine("You have reached the transmission of meter readings for Water");
                return;
            }
            else
            {
                base.HandleNext(choice);
            }
        }
    }
}
