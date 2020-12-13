using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.ObserverPattern
{
    class Subject
    {
        List<Observer> observers = new List<Observer>();
        private int state;

        public int State
        {
            get => state;
            set
            {
                state = value;
                NotifyAllObservers();
            }

        }
        public void attach(Observer observer)
        {
            this.observers.Add(observer);
        }
        public void NotifyAllObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
