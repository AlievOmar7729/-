using Abstract_Method;

DeviceFactory BalaxyFactory = new BalaxyFactory();
DeviceFactory IproneFactory = new IProneFactory();

INetbook check = BalaxyFactory.CreateNetbook();
Console.WriteLine("Balaxy Netbook: " + check);
check = IproneFactory.CreateNetbook();
Console.WriteLine("Balaxy Netbook: " + check);

