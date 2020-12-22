using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    class Cache
    {
        List<IService> Services;
        public Cache()
        {
            this.Services = new List<IService>();
        }
        public IService GetService(string name)
        {
            IService _ = Services.Where(p => p.GetName() == name).FirstOrDefault();
            if(_ != null)
            {
                Console.WriteLine("Returning cached  "+ name + " object");
                return _;
            }
            return null;
        }
        public void AddService(IService service)
        {
            IService _ = Services.Where(p => p.GetName() == service.GetName()).FirstOrDefault();
            if (_ == null)//找不到时，说明缓存中没有
            {
                this.Services.Add(service);
            }
        }
    }
}
