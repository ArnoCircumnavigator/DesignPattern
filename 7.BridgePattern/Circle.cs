using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BridgePattern
{
    public class Circle : Shape
    {
        int X, Y, Radius;
        public Circle(int x,int y,int radius,DrawAPI drawAPI)
            :base(drawAPI)
        {
            this.X = x;
            this.Y = y;
            this.Radius = radius;
        }

        public override void Draw()
        {
            base.DrawAPI.DrawCircle(this.X, this.Y, this.Radius);
        }
    }
}
