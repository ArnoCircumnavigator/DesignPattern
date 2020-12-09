using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 2;
        }
    }
}
