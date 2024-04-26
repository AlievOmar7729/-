using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private SmartTextReader _reader { get; set; }
        private Regex _regex { get; set; }

        public SmartTextReaderLocker(SmartTextReader reader, string regex)
        {

            this._reader = reader;
            this._regex = new Regex(regex);
        }

        public char[][]? ReadTextFile(string path)
        {
            if (_regex.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return null;
            }
            return _reader.ReadTextFile(path);
        }
    }
}
