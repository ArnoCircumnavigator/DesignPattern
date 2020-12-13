using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    class OctalObserver : Observer
    {
        public OctalObserver(Subject subject) : base(subject) { }
        internal override void Update()
        {
            Console.WriteLine("OctalObserver : " + Convert.ToString(base.subject.State, 8));
        }
    }
}
