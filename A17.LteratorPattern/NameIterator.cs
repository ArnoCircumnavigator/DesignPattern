using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.LteratorPattern
{
    class NameIterator : Iterator
    {
        string[] name;

        public NameIterator(string[] name)
        {
            this.name = name;
        }

        int index;
        public bool HasNext()
        {
            return index < name.Length;
        }

        public object Next()
        {
            if (this.HasNext())
                return name[index++];
            return null;
        }
    }
}
