using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();

            Shape cloneShape = (Shape)ShapeCache.GetShape("1");
            cloneShape.Draw();


            Console.ReadLine();
        }
    }
}
