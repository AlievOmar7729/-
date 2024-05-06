using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class LightElementNode : ILightNode
    {
        protected List<ILightNode> _children = new List<ILightNode>();
        private List<IEventListener> _subscribers = new List<IEventListener>();
        public string Tag { get; set; }
        public string DisplayType { get; set; }
        public bool ClosingType { get; set; }
        public List<string> CssClasses { get; set; }

        public LightElementNode()
        {
            _children = new List<ILightNode>();
            CssClasses = new List<string>();
            Tag = "div";
            DisplayType = "block";
            ClosingType = true;
        }



        public void AddChildren(ILightNode node)
        {
            _children.Add(node);
        }
        public void RemoveChildren(ILightNode node)
        {
            _children.Remove(node);
        }

        public void innerHTML()
        {
            foreach (var node in _children)
            {
                node.outerHTML();
            }
        }
        public void outerHTML()
        {
            if (CssClasses.Count == 0)
            {
                Console.WriteLine($"<{Tag}>");
            }
            else
            {
                Console.WriteLine($"<{Tag} class=\"{string.Join(" ", CssClasses)}\">");
            }

            innerHTML();
            if (DisplayType == "block")
            {
                Console.WriteLine($"</{Tag}{(ClosingType == true ? ">" : " />")}");
            }
        }

        public void Subscribe(IEventListener listener)
        {
            this._subscribers.Add(listener);
        }
        public void Unsubscribe(IEventListener listener)
        {
            this._subscribers.Remove(listener);
        }

        private void _notify()
        {
            _subscribers.ForEach((s) => s.Event());
        }
        public void InvokeEvents()
        {
            _notify();
        }

    }
}
