using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    interface DeviceFactory
    {
        public ILaptop CreateLaptop();
        public INetbook CreateNetbook();
        public IEBook CreateEBook();
        public ISmartphone CreateSmartphone();
    }
}
