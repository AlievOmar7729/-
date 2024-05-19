using Deafault;
using HTML.Command;
using HTML.State;

LightElementNode div = new LightElementNode()
{
    Tag = "div",
    DisplayType = "block",
    ClosingType = true,
    CssClasses = new List<string> { "Menu" }

};

div.AddChildren(new LightTextNode("Home"));
div.AddChildren(new LightTextNode("AboutMe"));
div.AddChildren(new LightTextNode("contacts"));
LightElementNode p = new LightElementNode()
{
    Tag = "p",
    DisplayType = "block",
    ClosingType = true,
};
div.AddChildren(p);
p.AddChildren(new LightTextNode("Omar Aliev IPZ-22-1"));

div.RemoveChildren(p);


//iterator
/*var dfi = div.GetDepthIterator();
while (!dfi.IsDone())
{
    Console.WriteLine("/////////////////");
    ILightNode node = (ILightNode)dfi.Next();
    node.outerHTML();
}



var bfi = div.GetBreadIterator();
while (!bfi.IsDone())
{
    Console.WriteLine("/////////////////");
    ILightNode node = (ILightNode)bfi.Next();
    node.outerHTML();
}*/

//command
/*LightElementNode div1 = new LightElementNode()
{
    Tag = "div",
    DisplayType = "block",
    ClosingType = true,
    CssClasses = new List<string> { "Menu" }
};
LightElementNode p1 = new LightElementNode()
{
    Tag = "p",
    DisplayType = "block",
    ClosingType = true,
};
LightTextNode text = new LightTextNode("Omar Aliev IPZ-22-1");

var addBlockCommand = new AddNodeCommand(div1, p1);
var addTextCommand = new AddNodeCommand(div1, text);

var invoker = new CommandInvoker();

invoker.ExecuteCommand(addBlockCommand);
invoker.ExecuteCommand(addTextCommand);

div1.outerHTML();

Console.WriteLine("-------UNDO------------");
invoker.Undo();
div1.outerHTML();*/

//state, template method

LightElementNode div1 = new LightElementNode()
{
    Tag = "div",
    DisplayType = "block",
    ClosingType = true,
    CssClasses = new List<string> { "Menu" }
};
LightElementNode p1 = new LightElementNode()
{
    Tag = "p",
    DisplayType = "block",
    ClosingType = true,
};
LightTextNode text = new LightTextNode("Omar Aliev IPZ-22-1");

var addBlockCommand = new AddNodeCommand(div1, p1);
var addTextCommand = new AddNodeCommand(div1, text);

var invoker = new CommandInvoker();

invoker.ExecuteCommand(addBlockCommand);
invoker.ExecuteCommand(addTextCommand);

Console.WriteLine("Initial HTML:");
div1.outerHTML();


Console.WriteLine("\nHTML after mouse over:");
p1.OnMouseOver();
div1.outerHTML();


Console.WriteLine("\nHTML after mouse out:");
p1.OnMouseOut();
div1.outerHTML();
text.Render();


