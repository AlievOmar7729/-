using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IRenderer
    {
        public void DrawCircle();
        public void DrawSquare();
        public void DrawTriangle();
    }
}
