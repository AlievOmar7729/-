using Deafault;

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
div.outerHTML();
div.RemoveChildren(p);

var dfi = div.GetDepthIterator();
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
}
