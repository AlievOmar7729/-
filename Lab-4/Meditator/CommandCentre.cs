using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meditator
{
    public class CommandCentre
    {

        private List<Aircraft> aircrafts = new List<Aircraft>();
        private List<Runway> runways = new List<Runway>();
        private int indexAircraft = 0;
        private int indexRunway = 0;

        private Aircraft aircraft;
        private Runway runway;

        public CommandCentre(Aircraft[] aircrafts, Runway[] runways)
        {

            foreach (Aircraft aircraft in aircrafts)
            {
                this.aircrafts.Add(aircraft);
            }
            foreach (Runway runway in runways)
            {
                this.runways.Add(runway);
            }
        }

        public void SetAircraftAndRunway(Aircraft aircraft, Runway runway)
        {
            this.aircraft = aircraft;
            this.aircraft.commandCentre = this;
            this.runway = runway;
            this.runway.commandCentre = this;
        }

        public void Notify(string ev)
        {
            if (ev == "Land")
            {
                Console.WriteLine($"Checking runway.");
                if (runway.IsBusyWithAircraft == false)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    runway.IsBusyWithAircraft = true;
                    runway.HighLightRed();
                }
                else
                {
                    Console.WriteLine($"Could not land, the runway is busy.");
                }
            }
            if (ev == "TakeOff")
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is taking off.");
                runway.IsBusyWithAircraft = false;
                runway.HighLightGreen();
                Console.WriteLine($"Aircraft {aircraft.Name} has took off.");

            }
        }

    }
}