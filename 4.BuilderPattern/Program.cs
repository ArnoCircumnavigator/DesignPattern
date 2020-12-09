using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder builder = new MealBuilder();
            Meal meal =  builder.GetMy_1Meal();
            Console.WriteLine("套餐1");
            meal.ShowItems();
            Console.WriteLine("总价" + meal.GetCost());

            meal = builder.GetMy_2Meal();
            Console.WriteLine("套餐1");
            meal.ShowItems();
            Console.WriteLine("总价" + meal.GetCost());


            Console.ReadKey();
        }
    }
}
