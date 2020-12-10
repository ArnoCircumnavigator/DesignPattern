using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO = new Employee("张三", "CEO", 20000);

            Employee UFO = new Employee("李四", "UFO", 10000);

            Employee WTY = new Employee("李四", "WTY", 5000);

            Employee UFO_1 = new Employee("ceo_1", "UFOer", 3000);
            Employee UFO_2 = new Employee("UFO_2", "UFOer", 3000);

            Employee WTY_1 = new Employee("ceo_1", "WTYer", 3000);
            Employee WTY_2 = new Employee("UFO_2", "WTYer", 3000);

            CEO.Add(UFO);
            CEO.Add(WTY);

            UFO.Add(UFO_1);
            UFO.Add(UFO_2);

            WTY.Add(WTY_1);
            WTY.Add(WTY_2);

            foreach(var t in CEO.GetSubordinates())
            {
                Console.WriteLine(t.ToString());
                foreach (var m in t.GetSubordinates())
                {
                    Console.WriteLine(m.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
