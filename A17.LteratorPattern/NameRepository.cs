using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.LteratorPattern
{
    class NameRepository : Container
    {
        public Iterator GetIterator()
        {
            return new NameIterator(names);
        }
        public string[] names = { "a", "b", "c", "d" };

    }
}
