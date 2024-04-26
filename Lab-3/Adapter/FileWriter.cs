using System;
using System.IO;

namespace Adapter
{
    public class FileWriter
    {
        public string path { get; private set; }

        public FileWriter(string path)
        {
            this.path = path;
        }

        public virtual void Write(string message)
        {
            Console.WriteLine($"Write [{message}] into without new line in [{path}]");
        }
        public virtual void WriteLine(string message)
        {
            Console.WriteLine($"Write [{message}] into with new line in [{path}]");
        }
    }
}