using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12.FlyweightPattern
{
    class Circle : IShape
    {
        public int x, y, radius;
        public string color;

        public Circle(string color)
        {
            this.color = string.IsNullOrEmpty(color) ? throw new ArgumentNullException(nameof(color)) : color;
        }

        public void Draw()
        {
            Console.WriteLine("Circle Draw() [color : " + color
                + ",x : " + x + ",y : " + y + ",radius : " + radius +
                "]");
        }
    }
}
