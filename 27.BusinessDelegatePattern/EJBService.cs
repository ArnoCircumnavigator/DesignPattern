using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27.BusinessDelegatePattern
{
    class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service");
        }
    }
}
