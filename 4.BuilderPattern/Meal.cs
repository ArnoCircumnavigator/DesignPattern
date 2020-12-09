using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BuilderPattern
{
    /// <summary>
    /// 菜单(可以理解成套餐)
    /// </summary>
    public class Meal
    {
        List<IItem> Items = new List<IItem>();

        public void Add(IItem item)
        {
            Items.Add(item);
        }
        public void Remove(IItem item)
        {
            Items.Remove(item);
        }
        public float GetCost()
        {
            float cost = 0;
            foreach (var t in Items)
            {
                cost += t.Price();
            }
            return cost;
        }
        public void ShowItems()
        {
            foreach (var t in Items)
            {
                Console.Write("Item : "+ t.Name());
                Console.Write(",Packing : " + t.Packing().Pack());
                Console.WriteLine(",Price : " + t.Price());
            }
        }
    }
}
