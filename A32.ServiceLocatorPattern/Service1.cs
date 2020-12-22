using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class Service1 : IService
    {
        string Name = "SERVICE1";
        public void Execute()
        {
            Console.WriteLine(this.Name + " is Executed");
        }

        public string GetName()
        {
            return this.Name;
        }
    }
}
