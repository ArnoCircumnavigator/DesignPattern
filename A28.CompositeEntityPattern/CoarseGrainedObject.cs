using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28.CompositeEntityPattern
{

    /// <summary>
    /// 粗颗粒对象
    /// 持有依赖对象
    /// 最主要的用处，就是管理这些个依赖对象的生命周期
    /// </summary>
    class CoarseGrainedObject
    {
        DependentObject1 object1 = new DependentObject1();
        DependentObject2 object2 = new DependentObject2();

        public void SetData(string data1,string data2)
        {
            object1.Data = data1;
            object2.Data = data2;
        }
        public string[] GetData()
        {
            return new string[] { this.object1.Data, this.object2.Data };
        }
    }
}
