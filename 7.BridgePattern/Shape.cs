using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BridgePattern
{
    public abstract class Shape
    {
        protected DrawAPI DrawAPI;
        protected Shape(DrawAPI drawAPI)
        {
            this.DrawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
