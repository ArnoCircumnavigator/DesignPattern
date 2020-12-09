using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCirle = new Circle(10, 10, 1, new RedCircle());
            Shape greenCirle = new Circle(10, 10, 1, new GreenCircle());

            redCirle.Draw();
            greenCirle.Draw();

            Console.ReadLine();
        }
    }
}
