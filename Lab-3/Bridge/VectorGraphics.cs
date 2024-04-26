using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class VectorGraphics : IRenderer
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing Circle as vector graphics");
        }

        public void DrawSquare()
        {
            Console.WriteLine("Drawing Square as vector graphics");
        }

        public void DrawTriangle()
        {
            Console.WriteLine("Drawing Triangle as vector graphics");
        }
    }
}
