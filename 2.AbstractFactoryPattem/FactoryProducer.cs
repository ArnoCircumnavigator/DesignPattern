using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class FactoryProducer
    {
        public AbstractFactory GetFactory(string factoryType)
        {
            if (string.Equals(factoryType, "Shape"))
                return new ShapeFactory();
            else if (string.Equals(factoryType, "Color"))
                return new ColorFactory();
            return null;
        }
    }
}
