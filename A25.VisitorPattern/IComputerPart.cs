using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.VisitorPattern
{
    interface IComputerPart
    {
        void Accept(IComputerPartVisitor visitor);
    }
}
