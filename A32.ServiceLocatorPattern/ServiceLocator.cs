using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class ServiceLocator
    {

        static Cache Cache;
        static ServiceLocator()
        {
            Cache = new Cache();
        }

        public static IService GetService(string name)
        {
            IService service = Cache.GetService(name);
            //缓存中有
            if (service != null)
                return service;
            //缓存中没有
            InitialContext context = new InitialContext();
            service = (IService)context.LookUp(name);
            Cache.AddService(service);
            return service;
        }
    }
}
