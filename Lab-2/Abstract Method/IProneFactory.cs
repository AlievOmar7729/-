using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    class IProneFactory : DeviceFactory
    {
        public IEBook CreateEBook()
        {
            return new IproneEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new IproneLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new IproneNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new IproneSmartphone();
        }
    }
}
