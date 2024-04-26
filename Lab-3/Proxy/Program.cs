using Proxy;

SmartTextReader reader = new SmartTextReader();
SmartTextChecker checker = new SmartTextChecker(reader);
SmartTextReaderLocker locker = new SmartTextReaderLocker(reader, @"KPZ");
checker.ReadTextFile("G:\\2 курс\\II сем\\KPZ\\Lab-3\\text.txt");
locker.ReadTextFile("G:\\2 курс\\II сем\\KPZ\\Lab-3\\text.txt");

