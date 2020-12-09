using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.FactoryPatterm
{
    class ShapeFactory
    {
        public IShape GetShape(string type)
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
