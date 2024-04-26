using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite;

namespace Flyweight
{
    public class DocumentReader
    {
        public static string path {  get; set; }
        public DocumentReader()
        {
            Console.WriteLine("BEFORE");
            Process proc = Process.GetCurrentProcess();
            Console.WriteLine($"{proc.PrivateMemorySize64 / (1024 * 1024)} МБ");
            Console.WriteLine($"{proc.WorkingSet64 / (1024 * 1024)} МБ");
            //ReaderWithFly(); -легковаговик
            ReaderWithoutFly();
            Console.WriteLine("AFTER");
            Process proc1 = Process.GetCurrentProcess();
            Console.WriteLine($"{proc1.PrivateMemorySize64 / (1024 * 1024)} МБ");
            Console.WriteLine($"{proc1.WorkingSet64 / (1024 * 1024)} МБ");
        }

        public static void ReaderWithoutFly()
        {
            var Root = new LightElementNode()
            {
                Tag = "html",
                DisplayType = "block",
                ClosingType = true
            };

            var body = new LightElementNode()
            {
                Tag = "body",
                DisplayType = "block",
                ClosingType = true
            };

            var lines = File.ReadAllLines(path);
            bool h1 = true;

            foreach(var line in lines)
            {
                if(string.IsNullOrWhiteSpace(line))
                    continue;
                LightElementNode node;
                if(h1 == true)
                {
                    node = new LightElementNode()
                    {
                        Tag = "h1",
                        DisplayType = "block",
                        ClosingType = true
                    };
                    h1 = false;
                }
                else if(line.Length < 20)
                {
                    node = new LightElementNode()
                    {
                        Tag = "h2",
                        DisplayType = "block",
                        ClosingType = true
                    };
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = new LightElementNode()
                    {
                        Tag = "blockquote",
                        DisplayType = "block",
                        ClosingType = true,
                    };
                }
                else
                {
                    node = new LightElementNode()
                    {
                        Tag = "p",
                        DisplayType = "block",
                        ClosingType = true,
                    };
                }
                node.AddChildren(new LightTextNode(line));
                body.AddChildren(node);
                
            }
            Root.AddChildren(body);



        }

        public static void ReaderWithFly()
        {
            var Root = new LightElementNodeFlyweight("html", "block", true);

            var body = new LightElementNodeFlyweight("body", "block", true);

            var lines = File.ReadAllLines(path);
            bool h1 = true;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                LightElementNodeFlyweight node;
                if (h1 == true)
                {
                    node = new LightElementNodeFlyweight("h1", "block", true);
                    h1 = false;
                }
                else if (line.Length < 20)
                {
                    node = new LightElementNodeFlyweight("h2","block",true);
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = new LightElementNodeFlyweight("blockquote","block",true);
                }
                else
                {
                    node = new LightElementNodeFlyweight("p","block",true);
                }
                node.AddChildren(new LightTextNode(line));
                body.AddChildren(node);

            }
            Root.AddChildren(body);
        }
    }
}
