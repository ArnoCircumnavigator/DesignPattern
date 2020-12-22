using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class InitialContext
    {
        public Object LookUp(string Name)
        {
            if (String.Equals(Name,"SERVICE1"))
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service1();
            }
            else
            {
                Console.WriteLine("Looking up and creating a new Service1 object");
                return new Service2();
            }
                
        }
    }
}
