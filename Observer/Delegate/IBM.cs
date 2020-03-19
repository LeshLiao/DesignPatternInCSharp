using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Delegate
{
    public class IBM : Stock
    {
        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}