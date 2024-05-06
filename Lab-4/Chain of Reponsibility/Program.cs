using Chain_of_Reponsibility;

var lev1 = new OneHandler();
var lev2 = new TwoHandler();
var lev3 = new ThreeHandler();
var lev4 = new ThreeHandler();

lev1.SetNextHandler(lev2);
lev2.SetNextHandler(lev3);
lev3.SetNextHandler(lev4);

Console.WriteLine("Choose what you want to transfer the meter reading for:");
Console.WriteLine("1.Gas");
Console.WriteLine("2.Light");
Console.WriteLine("3.Heating");
Console.WriteLine("4.Water");
string? input = Console.ReadLine();
int.TryParse(input,out int choice);
lev1.Handle(choice);