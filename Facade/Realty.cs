using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Realty
    {
        public void Buy()
        {
            Console.WriteLine("Buy " + this.GetType().ToString());
        }
        public void Sell()
        {
            Console.WriteLine("Sell " + this.GetType().ToString());
        }
    }
}