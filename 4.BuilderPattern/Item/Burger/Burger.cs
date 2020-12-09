using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    public abstract class Burger : IItem
    {
        public abstract string Name();

        public Packing Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
