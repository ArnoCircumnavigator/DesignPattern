using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19.MementoPattern
{
    class CareTaker
    {
        public List<Memento> MementoList { get; private set; } = new List<Memento>();
        public void Add(Memento memento)
        {
            this.MementoList.Add(memento);
        }
        public Memento Get(int index)
        {
            return MementoList[index];
        }
    }
}