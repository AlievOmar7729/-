using Adapter;

var fileLogger = new FileLogger(new Logger(),"text.txt");
fileLogger.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
fileLogger.Write("Tempor id eu nisl nunc mi ipsum. Elementum curabitur vitae nunc sed velit dignissim.");