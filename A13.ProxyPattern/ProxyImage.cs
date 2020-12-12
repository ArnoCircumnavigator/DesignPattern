using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13.ProxyPattern
{
    class ProxyImage : Image
    {
        RealImage realImage;
        string filename;

        public ProxyImage(string filename)
        {
            this.filename = string.IsNullOrEmpty(filename) ? throw new ArgumentNullException() : filename;
        }

        public void Display()
        {
            ///Image的这个代理(proxyimage)实现了一些对image的控制，这样实现解耦
            if(realImage == null)
            {
                realImage = new RealImage(filename);
            }
            realImage.Display();
        }
    }
}
