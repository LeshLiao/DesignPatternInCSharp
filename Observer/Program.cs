using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            Console.WriteLine("===== Original ======");


            Console.WriteLine("===== Delegete ======");
            Delegate.IBM delegateIBM = new Delegate.IBM("IBM", 120.00);
            Delegate.IInvestor delegateFirstInvestor = new Delegate.Investor("First: Sorros");
            Delegate.IInvestor delegateSecondInvestor = new Delegate.Investor("Second: Berkshire");
            delegateIBM.Update += delegateFirstInvestor.Update;
            delegateIBM.Update += delegateSecondInvestor.Update;
            delegateIBM.Update.Invoke(delegateIBM);
            delegateIBM.Price = 121.10;

            Console.WriteLine("===== Event ======");
            Event.IBM eventIBM = new Event.IBM("IBM", 120.00);
            Event.IInvestor eventFirstInvestor = new Event.Investor("First: Sorros");
            Event.IInvestor eventSecondInvestor = new Event.Investor("Second: Berkshire");
            eventIBM.Update += eventFirstInvestor.UpdateEvent;
            eventIBM.Update += eventSecondInvestor.UpdateEvent;
            eventIBM.Price = 121.10;
            Console.ReadKey();
        }
    }
}
