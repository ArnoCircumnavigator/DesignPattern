using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            ShapeDecotator redCircle = new RedShapeDecorator(new Circle());
            ShapeDecotator redRectangle = new RedShapeDecorator(new Rrctangle());
            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.Draw();

            Console.ReadLine();
        }
    }
}
