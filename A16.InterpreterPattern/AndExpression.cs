using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16.InterpreterPattern
{
    class AndExpression : IExpression
    {
        IExpression e1 = null;
        IExpression e2 = null;

        public AndExpression(IExpression e1, IExpression e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public bool interpret(string context)
        {
            return e1.interpret(context) && e2.interpret(context);
        }
    }
}
