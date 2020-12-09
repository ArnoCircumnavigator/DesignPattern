using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Blue");
        }
    }
}
