using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15.CommandPattern
{
    class BuyStock : Order
    {
        Stock stock;
        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }
        public void Execute()
        {
            stock.Buy();
        }
    }
}
