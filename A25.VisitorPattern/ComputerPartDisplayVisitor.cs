using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.VisitorPattern
{
    class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer");
        }

        public void Visit(Mose mose)
        {
            Console.WriteLine("Displaying mose");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Displaying monitor");
        }

        public void Visit(KeyBoard keyBoard)
        {
            Console.WriteLine("Displaying keyBoard");
        }
    }
}
