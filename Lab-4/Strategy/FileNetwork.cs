using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileNetwork : ILoadType
    {
        public void LoadIMG(string path)
        {
            Console.WriteLine($"The download from the network is complete {path}");
        }
    }
}
