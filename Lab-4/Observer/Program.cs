using Observer;

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
var cl = new Click();
p.Subscribe(cl);
p.Subscribe(new Mouseove());
p.AddChildren(new LightTextNode("Omar Aliev IPZ-22-1"));
p.Unsubscribe(cl);
div.outerHTML();
p.InvokeEvents();
