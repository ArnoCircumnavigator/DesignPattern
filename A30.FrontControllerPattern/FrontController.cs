using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A30.FrontControllerPattern
{
    class FrontController
    {
        Dispatcher _dispatcher;
        public FrontController()
        {
            _dispatcher = new Dispatcher();
        }

        bool IsAuthenticUser()
        {
            Console.WriteLine("验证通过");
            return true;
        }
        void TrackRequest(string request)
        {
            Console.WriteLine("Page requested : "+request);
        }
        public void DisPatchRequest(string request)
        {
            TrackRequest(request);
            if(IsAuthenticUser())
            {
                _dispatcher.Dispatch(request);
            }
        }
    }
}
