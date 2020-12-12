using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11.FacadePattern
{
    class ShapeMaker
    {
        Shape circle;
        Shape rectangle;
        Shape square;

        public ShapeMaker(Shape circle, Shape rectangle, Shape square)
        {
            this.circle = circle ?? throw new ArgumentNullException(nameof(circle));
            this.rectangle = rectangle ?? throw new ArgumentNullException(nameof(rectangle));
            this.square = square ?? throw new ArgumentNullException(nameof(square));
        }

        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rectangle.Draw();
        }
        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
