using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    abstract class Observer
    {
        public Observer(Subject subject)
        {
            this.subject = subject;
            this.subject.attach(this);
        }
        protected Subject subject;
        internal abstract void Update();
    }
}
