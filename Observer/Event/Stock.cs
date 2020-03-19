using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Event
{
    public abstract class Stock
    {
        private string _symbol;
        private double _price;

        //event
        public event EventHandler<Stock> Update;

        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }

        public void Notify()
        {
            if (Update != null)
            {
                Update(this, this);
            }
            //if event function no argus
            //Update(this, EventArgs.Empty);

            Console.WriteLine("");
        }
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
        public string Symbol
        {
            get { return _symbol; }
        }
    }
}