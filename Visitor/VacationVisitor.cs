using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class VacationVisitor : IVisitor
    {
        private int extraVacation;
        public VacationVisitor(int _extraVacation)
        {
            extraVacation = _extraVacation;
        }
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide 3 extra vacation days

            employee.VacationDays += extraVacation;
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
              employee.GetType().Name, employee.Name,
              employee.VacationDays);
        }
    }
}