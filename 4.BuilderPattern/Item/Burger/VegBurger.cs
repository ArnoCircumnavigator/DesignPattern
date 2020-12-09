using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg";
        }

        public override float Price()
        {
            return 5;
        }
    }
}
