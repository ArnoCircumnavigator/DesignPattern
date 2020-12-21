using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27.BusinessDelegatePattern
{
    class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string serviceType)
        {
            if (serviceType.Equals("EJB"))
                return new EJBService();
            else
                return new JMSService();
        }
    }
}
