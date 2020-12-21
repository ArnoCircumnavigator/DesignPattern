using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A27.BusinessDelegatePattern
{
    /// <summary>
    /// 这不是一个委托，而是业务代表
    /// </summary>
    class BusinessDelegate
    {
        BusinessLookUp lookupService = new BusinessLookUp();//用来查找服务
        IBusinessService businessService;
        public string serviceType;

        public void DoTask()
        {
            //业务代表在做任务之前，先让【查询服务】去吧具体的实现找出来
            businessService = lookupService.GetBusinessService(this.serviceType);

            //然后开始做任务
            businessService.DoProcessing();
        }
        
    }
}
