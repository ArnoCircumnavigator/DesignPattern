using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16.InterpreterPattern
{
    class TerminalExpression : IExpression
    {
        string data;

        public TerminalExpression(string data)
        {
            this.data = data;
        }

        public bool interpret(string context)
        {
            if(context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
