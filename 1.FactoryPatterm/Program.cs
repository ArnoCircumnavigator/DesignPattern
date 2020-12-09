using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FactoryPatterm
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            IShape shape = factory.GetShape("Circle");
            shape.Draw();

            shape = factory.GetShape("Square");
            shape.Draw();

            shape = factory.GetShape("Rectangle");
            shape.Draw();

            Console.ReadLine();
        }
    }
}
