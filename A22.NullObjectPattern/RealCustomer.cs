using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22.NullObjectPattern
{
    class RealCustomer : AbstractCusmer
    {
        public RealCustomer(string name)
        {
            base.Name = name;
        }
        public override string GetName()
        {
            return base.Name;
        }

        public override bool IsNil()
        {
            return false;
        }
    }
}
