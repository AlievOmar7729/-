using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReader : ITextReader
    {
        public char[][]? ReadTextFile(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                char[][] charArray = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    charArray[i] = lines[i].ToCharArray();
                }
                return charArray;
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
                return null;
            }
        }
    }
}
