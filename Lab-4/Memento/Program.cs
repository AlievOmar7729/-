

using Memento;

var Documenttxt = new TextDocument("Text:");
var Editortxt = new TextEditor(Documenttxt);
Documenttxt.AddContent("First Edit;");
Editortxt.Save();
Documenttxt.AddContent("Second Edit;");
Editortxt.Save();
Editortxt.DocumentHistory();
Console.WriteLine($"{Documenttxt}");
Editortxt.Undo();
Editortxt.Undo();
Console.WriteLine($"{Documenttxt}");


Documenttxt.AddContent("TEST Edit;");
Editortxt.Save();
Console.WriteLine($"{Documenttxt}");



