using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23.StrategyPattern
{
    class Context
    {
        IStrategy _strategy;
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }
        public int Do(int num1,int num2)
        {
            return this._strategy.Do(num1,num2);
        }
    }
}
