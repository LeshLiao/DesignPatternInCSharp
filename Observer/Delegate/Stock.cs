using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Delegate
{
    public abstract class Stock
    {
        private string _symbol;
        private double _price;
        //delegate
        public delegate void StockHandler(Stock stock); //declaring a delegate
        public StockHandler Update;                     //creating an object of delegate

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Notify()
        {
            Update.Invoke(this);
            Console.WriteLine("");
        }
        // Gets or sets the price
        public double Price
        {
            get { return _price; }
            set

            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }
        // Gets the symbol
        public string Symbol
        {
            get { return _symbol; }
        }
    }
}