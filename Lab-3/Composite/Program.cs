using Composite;

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

