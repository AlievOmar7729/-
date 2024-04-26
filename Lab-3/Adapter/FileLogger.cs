using System;

namespace Adapter
{
    public class FileLogger : FileWriter
    {
        private readonly Logger logger;

        public FileLogger(Logger logger, string path) : base(path)
        {
            this.logger = logger;
        }
        public override void Write(string message)
        {
            FileLoggerOutput(base.Write, message);


        }
        public override void WriteLine(string message)
        {
            FileLoggerOutput(base.WriteLine, message);
        }

        private void FileLoggerOutput(Action<string> methods, string message)
        {
            Random random = new();
            switch (random.Next(1, 4))
            {
                case 1:
                    logger.Log(message);
                    break;
                case 2:
                    logger.Warn(message);
                    break;
                case 3:
                    logger.Error(message);
                    break;
            }
            methods(message);
            Console.ResetColor();
        }


    }
}