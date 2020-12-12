using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A10.DecoratorPattern
{
    public abstract class ShapeDecotator
    {
        public IShape Shape { get; set; }
        public ShapeDecotator(IShape decoratedShape)
        {
            this.Shape = decoratedShape;
        }
        public virtual void Draw()
        {
            this.Shape.Draw();
        }
    }
}
