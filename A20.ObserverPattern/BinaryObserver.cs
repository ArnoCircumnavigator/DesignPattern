using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
            : base(subject) { }

        internal override void Update()
        {
            Console.WriteLine("BinaryObserver : " + Convert.ToString(base.subject.State, 2)); ;
        }
    }
}
