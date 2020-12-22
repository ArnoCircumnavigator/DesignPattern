using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IService service = ServiceLocator.GetService("SERVICE1");//新建
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");//新建
            service.Execute();
            service = ServiceLocator.GetService("SERVICE1");//缓存
            service.Execute();
            service = ServiceLocator.GetService("SERVICE2");//缓存
            service.Execute();
        }
    }
}
