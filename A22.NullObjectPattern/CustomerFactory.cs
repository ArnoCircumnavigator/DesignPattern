using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22.NullObjectPattern
{
    class CustomerFactory
    {
        public static string[] names = { "Rob", "Joe", "Julie" };
        public static AbstractCusmer GetCustomer(string name)
        {
            for(int  i = 0;i<name.Length;i++)
            {
                if(string.Equals(names[i],name))//存在
                {
                    return new RealCustomer(name);//实际的对象
                }
            }
            return new NullCustomer();//空对象
        }
    }
}
