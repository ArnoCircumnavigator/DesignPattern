using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    class HexObserver : Observer
    {
        public HexObserver(Subject subject) : base(subject) { }
        internal override void Update()
        {
            Console.WriteLine("HexObserver : " + Convert.ToString(base.subject.State, 16));
        }
    }
}
