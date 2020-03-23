using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public class President : Employee
    {
        public President(): base("Dick", 45000.0, 21)
        {
        }
    }
}