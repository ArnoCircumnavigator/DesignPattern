using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31.InterceptingFilterPattern
{
    interface IFilter
    {
        void Execute(string request);
    }
}
