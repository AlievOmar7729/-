using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Method
{
    class KiaomiFactory : DeviceFactory
    {
        public IEBook CreateEBook()
        {
            return new KiaomiEBook();
        }

        public ILaptop CreateLaptop()
        {
            return new KiaomiLaptop();
        }

        public INetbook CreateNetbook()
        {
            return new KiaomiNetbook();
        }

        public ISmartphone CreateSmartphone()
        {
            return new KiaomiSmartphone();
        }
    }
}
