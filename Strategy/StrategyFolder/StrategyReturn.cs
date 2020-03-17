using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class StrategyReturn : StrategySuper
    {
        int returnCondition;
        int returnCash;
        
        public StrategyReturn(int _returnCondition, int _returnCash)
        {
            returnCondition = _returnCondition;
            returnCash = _returnCash;
        }
        public override decimal CalculateCash(decimal money)
        {
            decimal result = money - (Math.Floor(money / returnCondition) * returnCash);
            return result;
        }
    }
}