using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    /// <summary>
    /// 菜单建造者
    /// </summary>
    public class MealBuilder
    {
        public Meal GetMy_1Meal()
        {
            Meal meal = new Meal();
            meal.Add(new VegBurger());
            meal.Add(new Coke());
            meal.Add(new Pepsi());
            return meal;
        }
        public Meal GetMy_2Meal()
        {
            Meal meal = new Meal();
            meal.Add(new ChickenBuiger());
            meal.Add(new Pepsi());
            meal.Add(new Pepsi());
            return meal;
        }
    }
}
