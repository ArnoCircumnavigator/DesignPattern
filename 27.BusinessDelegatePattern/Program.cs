using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27.BusinessDelegatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate();
            businessDelegate.serviceType = "EJB";

            Client client = new Client(businessDelegate);
            client.DoTask();

            businessDelegate.serviceType ="JMS";
            client.DoTask();
        }
    }
}
