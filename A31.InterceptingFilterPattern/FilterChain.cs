using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31.InterceptingFilterPattern
{
    class FilterChain
    {
        List<IFilter> Filters = new List<IFilter>();
        Target target;

        public void AddFilter(IFilter filter)
        {
            Filters.Add(filter);
        }
        public void Execute(string request)
        {
            foreach(var t in Filters)
            {
                t.Execute(request);
            }
            target.Execute(request);
        }
        public void SetTarget(Target target)
        {
            this.target = target;
        }
    }
}
