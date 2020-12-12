using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10.DecoratorPattern
{
    public class RedShapeDecorator:ShapeDecotator
    {
        public RedShapeDecorator(IShape decoratedShape)
            : base(decoratedShape) { }

        public override void Draw()
        {
            this.Shape.Draw();
            SetRedBroder(this.Shape);
        }
        void SetRedBroder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color:Red");
        }
    }
}
