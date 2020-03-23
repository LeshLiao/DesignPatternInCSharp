using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class Clerk : Employee
    {
        public Clerk() : base("Hank", 25000.0, 14)
        {
        }
    }
}