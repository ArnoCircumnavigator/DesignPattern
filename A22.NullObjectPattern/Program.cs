using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22.NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCusmer cusmer1 = CustomerFactory.GetCustomer("Rob");
            AbstractCusmer cusmer2 = CustomerFactory.GetCustomer("Joe");
            AbstractCusmer cusmer3 = CustomerFactory.GetCustomer("Julie");
            AbstractCusmer cusmer4 = CustomerFactory.GetCustomer("张三");

            Console.WriteLine("Customers");
            Console.WriteLine(cusmer1.GetName());
            Console.WriteLine(cusmer2.GetName());
            Console.WriteLine(cusmer3.GetName());
            Console.WriteLine(cusmer4.GetName());
        }
    }
}
