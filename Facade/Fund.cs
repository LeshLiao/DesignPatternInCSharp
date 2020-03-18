using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Fund
    {
        Stock stock;
        Realty realty;
        NationalDebt nationalDebt;
        public Fund()
        {
            stock = new Stock();
            realty = new Realty();
            nationalDebt = new NationalDebt();
        }
        public void BuyFund()
        {
            stock.Buy();
            realty.Buy();
            nationalDebt.Buy();
        }
        public void SellFund()
        {
            stock.Sell();
            realty.Sell();
            nationalDebt.Sell();
        }
    }
}