using Prototype;

Virus FirstMain = new Virus(10.5,10,"FirstMain", "Heavy");
Virus SecondMain = new Virus(5.5, 10, "SecondMain", "Heavy");

Virus childVirus1 = new Virus(0.8, 2, "Child1", "Light");
Virus childVirus2 = new Virus(0.9, 1, "Child2", "Light");

FirstMain.AddChild(SecondMain);
SecondMain.AddChild(childVirus1);
SecondMain.AddChild(childVirus2);



FirstMain.PrintDetails();

Virus childVirus3Copy = new Virus(0.9, 1, "Child3", "Light");

Virus Copy = (Virus)FirstMain.Clone();
Copy.PrintDetails();
Copy.AddChild(childVirus3Copy);
Copy.PrintDetails();





/*grandParentVirus.AddChild(parentVirus);
parentVirus.AddChild(childVirus1);
parentVirus.AddChild(childVirus2);

Console.WriteLine("Original Virus Family:");
grandParentVirus.PrintDetails();

Virus clonedVirusFamily = (Virus)grandParentVirus.Clone();

Console.WriteLine("\nCloned Virus Family:");
clonedVirusFamily.PrintDetails();*/