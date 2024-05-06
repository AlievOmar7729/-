using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileSystem : ILoadType
    {
        public void LoadIMG(string path)
        {
            Console.WriteLine($"The download from system is complete {path}");
        }
    }
}
