using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Event
{
    public interface IInvestor
    {
        void UpdateEvent(object sender, Stock stock);
    }
}