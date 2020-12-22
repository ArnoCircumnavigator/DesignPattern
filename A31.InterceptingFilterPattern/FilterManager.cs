using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31.InterceptingFilterPattern
{
    class FilterManager
    {
        FilterChain FilterChain;
        public FilterManager(Target target)
        {
            FilterChain = new FilterChain();
            FilterChain.SetTarget(target);
        }
        public void SetFilter(IFilter filter)
        {
            FilterChain.AddFilter(filter);
        }
        public void FilterRequest(string request)
        {
            FilterChain.Execute(request);
        }
    }
}
