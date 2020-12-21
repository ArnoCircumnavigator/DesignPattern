using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28.CompositeEntityPattern
{
    class Client
    {
        /// <summary>
        /// 客户端需要的实体
        /// </summary>
        CompositeEntity Entity = new CompositeEntity();
        public void PrintData()
        {
            foreach(var s in Entity.GetData())
            {
                Console.WriteLine("[Data : " + s);
            }
        }
        /// <summary>
        /// 这个方法就是，组合对象的实例化过程
        /// 既然是组合对象，那么由那些东西才能组合出这个组合对象，客户端是知道的
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        public void SetData(string data1,string data2)
        {
            this.Entity.SetData(data1, data2);
        }
    }
}
