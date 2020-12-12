using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12.FlyweightPattern
{
    class ShapeFactory
    {
        public static Hashtable CircleMap = new Hashtable();
        

        public static IShape GetCile(string color)
        {
            if (string.IsNullOrEmpty(color))
                throw new ArgumentNullException();
            //从缓存中拿
            Circle circle = (Circle)CircleMap[color];
            //新建
            if(circle == null)
            {
                circle = new Circle(color);
                CircleMap.Add(color, circle);
            }
            return circle;
        }
    }
}
