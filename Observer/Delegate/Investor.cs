﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Delegate
{
    public class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;
        public Investor(string name)
        {
            this._name = name;
        }
        public void Update(Stock stock)
        {
            Console.WriteLine("(Delegate.Investor) Notified {0} of {1}'s " +
              "change to {2:C}", _name, stock.Symbol, stock.Price);
        }
        public Stock Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        
    }
}