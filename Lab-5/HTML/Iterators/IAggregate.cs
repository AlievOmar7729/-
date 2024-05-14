using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTML.Iterators
{
    public interface IAggregate
    {
        public IIterator GetDepthIterator();
        public IIterator GetBreadIterator();
    }
}
