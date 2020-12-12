using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13.ProxyPattern
{
    class RealImage : Image
    {
        string filename;

        public RealImage(string filename)
        {
            this.filename = filename ?? throw new ArgumentNullException(nameof(filename));
            LoadFromDisk(filename);
        }

        public void Display()
        {
            Console.WriteLine("Display "+filename);
        }
        void LoadFromDisk(string filename)
        {
            Console.WriteLine("Loding " + filename);
        }
    }
}
