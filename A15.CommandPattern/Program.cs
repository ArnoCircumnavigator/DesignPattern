
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Stock stock = new Stock();

            BuyStock buyStock = new BuyStock(stock);
            SellStock sellStock = new SellStock(stock);

            BroKet broKet = new BroKet();
            broKet.TakeOrdet(buyStock);
            broKet.TakeOrdet(sellStock);
            broKet.PlaceOrders();
        }
    }
}
