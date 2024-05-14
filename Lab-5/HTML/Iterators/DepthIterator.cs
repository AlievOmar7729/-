using Deafault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Iterators
{
    public class DepthIterator : IIterator
    {
        private List<ILightNode> list = new List<ILightNode>();
        private int _cursor = -1;

        public DepthIterator(ILightNode node)
        {
            DFS(node);
        }
        private void DFS(ILightNode node)
        {
            if (node == null)
            {
                return;
            }
            list.Add(node);
            if (node is LightElementNode)
            {
                var children = ((LightElementNode)node).GetChildren();
                foreach (var child in children)
                {
                    DFS(child);
                }
            }
        }

        public object? Current()
        {
            return this._cursor >= 0 && _cursor < list.Count ? list[_cursor] : null;
        }

        public bool IsDone()
        {
            return this._cursor == this.list.Count - 1;
        }

        public object? Next()
        {

            return this.IsDone() ? null : Current();
        }

        public void Reset()
        {
            _cursor = -1;
            list.Clear();
        }
    }
}
