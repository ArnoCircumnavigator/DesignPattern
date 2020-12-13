using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A21.StatePattern
{
    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in Stop State");
            context.state = this;
        }
        public override string ToString()
        {
            return "Stop State";
        }
    }
}
