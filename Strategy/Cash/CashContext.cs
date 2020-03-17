using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class CashContext
    {
        StrategySuper myStragety;
        public CashContext(int index)
        {
            switch(index)
            {
                case 0:
                    myStragety = new StrategyNormal();
                    break;
                case 1:
                    myStragety = new StrategyRebate((decimal)0.8);
                    break;
                case 2:
                    myStragety = new StrategyReturn(300,100);
                    break;
            }
        }
        public decimal GetResult(decimal money)
        {
            return myStragety.CalculateCash(money);
        }
    }
}