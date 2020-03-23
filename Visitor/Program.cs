using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.ToRewardAllEmployees(new IncomeVisitor(1.1));   // Everyone get a raise of 10% 
            e.ToRewardAllEmployees(new VacationVisitor(2));   // Everyone get 2 days leave

            Console.ReadKey();
        }
    }
}
