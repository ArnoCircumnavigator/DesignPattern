using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A28.CompositeEntityPattern
{
    /// <summary>
    /// 组合实体
    /// </summary>
    class CompositeEntity
    {
        CoarseGrainedObject go = new CoarseGrainedObject();

        /// <summary>
        /// 组合实体在作出变动时，应该让他的粗颗粒对象去操作那些个依赖对象
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        public void SetData(string data1,string data2)
        {
            go.SetData(data1, data2);
        }
        public string[] GetData()
        {
            return go.GetData();
        }
    }
}
