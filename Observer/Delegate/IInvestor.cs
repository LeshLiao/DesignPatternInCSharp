using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observer.Delegate
{
    public interface IInvestor
    {
        void Update(Stock stock);

    }
}