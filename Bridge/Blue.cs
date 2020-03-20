using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Blue : Color
    {
        public Blue()
        {
            this.color = "Blue";
        }
        public override string getColor()
        {
            return color;
        }
    }
}