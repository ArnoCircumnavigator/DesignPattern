using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SingletonPatterm
{
    class Single
    {
        private static Single instance = new Single();
        public static Single GetInstance() => instance;
        private Single() { }
        public void Do()
        {
            Console.WriteLine("I'm a Single");
        }
    }
}
