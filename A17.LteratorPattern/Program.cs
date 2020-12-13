using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A17.LteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            NameRepository repository = new NameRepository();
            for (Iterator iter = repository.GetIterator();iter.HasNext();)
            {
                Console.WriteLine("Name : " + iter.Next());
            }
        }
    }
}
