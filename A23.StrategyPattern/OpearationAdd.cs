using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23.StrategyPattern
{
    class OpearationAdd : IStrategy
    {
        public int Do(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class OpearationSubstract : IStrategy
    {
        public int Do(int num1, int num2)
        {
            return num1 - num2;
        }
    }
    class OpearationMultiply : IStrategy
    {
        public int Do(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
