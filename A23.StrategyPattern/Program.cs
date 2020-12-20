using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23.StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new OpearationAdd());
            Console.WriteLine("10+5 = "+context.Do(10, 5));
            context = new Context(new OpearationSubstract());
            Console.WriteLine("10-5 = "+context.Do(10, 5));
            context = new Context(new OpearationMultiply());
            Console.WriteLine("10*5 = "+context.Do(10, 5)); 
        }
    }
}
