using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class StrategyRebate : StrategySuper
    {
        decimal rebatePercent;
        public StrategyRebate(decimal _rebatePercent)
        {
            rebatePercent = _rebatePercent;
        }
        public override decimal CalculateCash(decimal money)
        {
            return money * rebatePercent;
        }
    }
}