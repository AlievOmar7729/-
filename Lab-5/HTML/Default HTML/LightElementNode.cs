using HTML.Iterators;
using HTML.State;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deafault
{
    public class LightElementNode : ILightNode, IAggregate
    {
        protected List<ILightNode> _children = new List<ILightNode>();
        public string Tag { get; set; }
        public string DisplayType { get; set; }
        public bool ClosingType { get; set; }
        public List<string> CssClasses { get; set; }
        private IState _state;
        public IState State
        {
            get { return _state; }
            set
            {
                _state = value;
                _state.Handle(this);
            }
        }

        public LightElementNode()
        {
            _children = new List<ILightNode>();
            CssClasses = new List<string>();
            Tag = "div";
            DisplayType = "block";
            ClosingType = true;

            _state = new NormalState();
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


        public List<ILightNode> GetChildren() => _children;

        public IIterator GetDepthIterator() => new DepthIterator(this);

        public IIterator GetBreadIterator() => new BreadthIterator(this);

        public void OnMouseOver()
        {
            State = new HoverState();
        }
        public void OnMouseOut()
        {
            State = new NormalState();
        }
    }
}
