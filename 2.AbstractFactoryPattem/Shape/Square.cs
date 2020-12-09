using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
