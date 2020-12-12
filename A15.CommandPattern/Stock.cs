using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15.CommandPattern
{
    class Stock
    {
        string name = "ABC";
        int quantity = 100;
        public void Buy()
        {
            Console.WriteLine("buy Stock [ Nmae : " + name + ",Quantity : " + quantity);
        }
        public void Sell()
        {
            Console.WriteLine("sell Stock [ Nmae : " + name + ",Quantity : " + quantity);
        }
    }
}
