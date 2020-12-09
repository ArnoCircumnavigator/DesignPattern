using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.PrototypePattern
{
    public class ShapeCache
    {
        static Hashtable ShapeMap = new Hashtable();

        public ShapeCache()
        {
            
        }
        public static Shape GetShape(string shapeID)
        {
            Shape cache = (Shape)ShapeMap[shapeID];
            return (Shape)cache.Clone();
        }
        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.SetID("1");
            ShapeMap.Add(circle.GetID(), circle);

            Square square = new Square();
            square.SetID("2");
            ShapeMap.Add(square.GetID(), square);

            Rectangle rectangle = new Rectangle();
            rectangle.SetID("3");
            ShapeMap.Add(rectangle.GetID(), rectangle);

        }
    }
}
