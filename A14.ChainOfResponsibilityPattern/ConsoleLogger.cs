using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14.ChainOfResponsibilityPattern
{
    class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
            :base(level)
        {
            
        }

        public override void write(string message)
        {
            Console.WriteLine("Standard Console :: logger : " + message);
        }
    }
}
