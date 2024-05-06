
using Meditator;

Aircraft a1 = new Aircraft("an-255 mriya");
Aircraft a2 = new Aircraft("boeing 747");



Runway r1 = new Runway();
Runway r2 = new Runway();
Runway r3 = new Runway(); 

var command = new CommandCentre(new Aircraft[] {a1,a2},new Runway[] {r1,r2,r3});

command.SetAircraftAndRunway(a1, r1);

a1.Land();
command.SetAircraftAndRunway(a2, r1);
a2.Land();