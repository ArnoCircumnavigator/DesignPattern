using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();

        public Packing Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}
