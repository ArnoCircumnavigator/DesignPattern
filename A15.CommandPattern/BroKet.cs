using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15.CommandPattern
{
    class BroKet
    {
        List<Order> orders = new List<Order>();
        public void TakeOrdet(Order order)
        {
            orders.Add(order);
        }
        public void PlaceOrders()
        {
            foreach(var order in orders)
            {
                order.Execute();
            }
            orders.Clear();
        }
    }
}
