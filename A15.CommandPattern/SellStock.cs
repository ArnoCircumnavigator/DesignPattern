using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A15.CommandPattern
{
    class SellStock : Order
    {
        Stock stock;

        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            this.stock.Sell();
        }
    }
}
