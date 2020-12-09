using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    class ChickenBuiger : Burger
    {
        public override string Name()
        {
            return "Chicken";
        }

        public override float Price()
        {
            return 10;
        }
    }
}
