using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class SmartTextChecker : ITextReader
    {
        private SmartTextReader _reader { get; set; }
        public SmartTextChecker(SmartTextReader reader)
        {
            this._reader = reader;
        }


        public char[][]? ReadTextFile(string path)
        {

            Console.WriteLine("Opening file: " + path);
            char[][] result = _reader.ReadTextFile(path);
            Console.WriteLine("Successfully read file: " + path);
            Console.WriteLine($"Total lines: {result.Length}, Total characters: {string.Join("", result.SelectMany(s => s)).Length}");
            Console.WriteLine("Closing file: " + path);
            return result;
        }

    }
}
