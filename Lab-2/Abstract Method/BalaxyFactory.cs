using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    class BalaxyFactory : DeviceFactory
    {
        public IEBook CreateEBook()
        {
            return new BalaxyEBook();
        }

        public ILaptop CreateLaptop()
        {
            Console.WriteLine("Лаптор Балаксі зроблено !");
            return new BalaxyLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new BalaxyNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new BalaxySmartphone();
        }
    }
}
