using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.LteratorPattern
{
    interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
