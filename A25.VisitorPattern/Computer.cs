using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.VisitorPattern
{
    class Computer : IComputerPart
    {
        IComputerPart[] parts;
        public Computer()
        {
            parts = new IComputerPart[] {
                new Mose(),
                new KeyBoard(),
                new Monitor()
            };
        }
        void IComputerPart.Accept(IComputerPartVisitor visitor)
        {
            foreach(var t in parts)
            {
                t.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}
