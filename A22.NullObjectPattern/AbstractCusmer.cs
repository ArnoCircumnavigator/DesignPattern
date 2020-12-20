using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22.NullObjectPattern
{
    abstract class AbstractCusmer
    {
        protected string Name;
        public abstract bool IsNil();
        public abstract string GetName();
    }
}
