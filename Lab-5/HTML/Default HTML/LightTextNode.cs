using HTML.Template_Method;
using HTML.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Deafault
{
    public class LightTextNode : LightNodeBase, ILightNode
    {
        public string text { get; set; }

        public LightTextNode(string text)
        {
            this.text = text;
        }

        public override void innerHTML()
        {
            Console.WriteLine(text);
        }
        public override void outerHTML()
        {
            Console.WriteLine(text);
        }



        protected override void OnCreated() => Console.WriteLine($"Text node created with text: {text}");
        protected override void OnInserted() => Console.WriteLine($"Text node inserted into the DOM with text: {text}");
        protected override void OnRemoved() => Console.WriteLine($"Text node removed from the DOM with text: {text}");
        protected override void RenderText() => Console.WriteLine($"Text rendered: {text}");

        public override void Accept(ILightNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
