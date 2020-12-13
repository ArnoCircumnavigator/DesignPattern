using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18.MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi,I'm robert");
            john.SendMessage("Hi,I'm john");
        }
    }
}
