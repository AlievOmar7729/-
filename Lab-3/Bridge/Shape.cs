using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape
    {

        protected IRenderer _renderer;

        protected Shape(IRenderer renderer)
        {
            this._renderer = renderer;
        }

        public abstract void Draw();

        public void SetRender(IRenderer renderer)
        {
            this._renderer = renderer;
        }
    }
}
