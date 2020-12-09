using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SingletonPatterm
{
    class Program
    {
        static void Main(string[] args)
        {
            Single single = Single.GetInstance();
            single.Do();
            Console.ReadLine();
        }
    }
}
