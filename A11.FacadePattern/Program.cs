using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11.FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            //对于Program这个客户端来说，唯一和ShapeMaker耦合
            ShapeMaker maker = new ShapeMaker(circle,rectangle,square);
            maker.DrawCircle();
            maker.DrawRectangle();
            maker.DrawSquare();
        }
    }
}
