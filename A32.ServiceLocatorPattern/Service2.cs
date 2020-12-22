using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class Service2 : IService
    {
        string Name = "SERVICE2";
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
