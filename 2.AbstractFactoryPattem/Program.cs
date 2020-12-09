using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryProducer producer = new FactoryProducer();
            AbstractFactory @abstract =  producer.GetFactory("Shape");
            IShape shape = @abstract.GetShape("Circle");
            shape.Draw();

            shape = @abstract.GetShape("Rectangle");
            shape.Draw();

            shape = @abstract.GetShape("Square");
            shape.Draw();

            @abstract = producer.GetFactory("Color");

            IColor color = @abstract.GetColor("Red");
            color.Fill();

            color = @abstract.GetColor("Green");
            color.Fill();

            color = @abstract.GetColor("Blue");
            color.Fill();

            Console.ReadLine();
        }
    }
}
