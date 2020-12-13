using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            subject.State = 3;

            new BinaryObserver(subject);
            new OctalObserver(subject);
            new HexObserver(subject);

            Console.WriteLine("First State change:15");
            subject.State = 15;

            Console.WriteLine("Second State change:88");
            subject.State = 88;
        }
    }
}
