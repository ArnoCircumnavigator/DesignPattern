using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14.ChainOfResponsibilityPattern
{
    class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
            :base(level)
        {
            
        }

        public override void write(string message)
        {
            Console.WriteLine("File :: Logger : " + message);
        }
    }
}
