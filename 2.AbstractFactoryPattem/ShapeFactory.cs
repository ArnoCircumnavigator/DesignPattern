using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class ShapeFactory: AbstractFactory
    {
        public override IColor GetColor(string type)
        {
            return null;
        }

        public override IShape GetShape(string type)
        {
            IShape shape = null;
            switch (type)
            {
                case "Circle":
                    shape = new Circle();
                    break;
                case "Square":
                    shape = new Square();
                    break;
                case "Rectangle":
                    shape = new Rectangle();
                    break;
            }
            return shape;
        }
    }
}
