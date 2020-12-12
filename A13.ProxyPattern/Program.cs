using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13.ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new ProxyImage("test.jpg");

            image.Display();

            Console.WriteLine("当image不需要加载时");
            image.Display();
        }
    }
}
