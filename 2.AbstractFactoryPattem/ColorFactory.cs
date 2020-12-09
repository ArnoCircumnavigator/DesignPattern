using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AbstractFactoryPattem
{
    class ColorFactory:AbstractFactory
    {
        public override IColor GetColor(string type)
        {
            IColor color = null;
            switch (type)
            {
                case "Blue":
                    color = new Blue();
                    break;
                case "Green":
                    color = new Green();
                    break;
                case "Red":
                    color = new Red();
                    break;
            }
            return color;
        }

        public override IShape GetShape(string type)
        {
            return null;
        }
    }
}
