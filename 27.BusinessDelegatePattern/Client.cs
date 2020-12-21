using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27.BusinessDelegatePattern
{
    class Client
    {
        BusinessDelegate businessServer;//从命名可以看出，对于这个客户端而言，业务代表就是服务本体

        public Client(BusinessDelegate businessServer)
        {
            this.businessServer = businessServer ?? throw new ArgumentNullException(nameof(businessServer));
        }
        public void DoTask()
        {
            this.businessServer.DoTask();
        }
    }
}
