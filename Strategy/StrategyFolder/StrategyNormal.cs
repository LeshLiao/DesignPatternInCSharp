using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    public class StrategyNormal : StrategySuper
    {
        public override decimal CalculateCash(decimal money)
        {
            return money;
        }
    }
}