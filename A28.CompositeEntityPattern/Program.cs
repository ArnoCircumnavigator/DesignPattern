using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28.CompositeEntityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //组一个
            client.SetData("Test","Data");
            client.PrintData();

            //再组一个
            client.SetData("Second","Data1");
            client.PrintData();
        }
    }
}
