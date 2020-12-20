using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.VisitorPattern
{
    interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mose mose);
        void Visit(Monitor monitor);
        void Visit(KeyBoard keyBoard);
    }
}
