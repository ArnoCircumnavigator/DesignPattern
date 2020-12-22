using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31.InterceptingFilterPattern
{
    class DebugFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine("Debug response " + request);
        }
    }
}
