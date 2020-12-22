using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A32.ServiceLocatorPattern
{
    interface IService
    {
        string GetName();
        void Execute();
    }
}
