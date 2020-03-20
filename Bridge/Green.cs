using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Green : Color
    {
        public Green()
        {
            this.color = "Green";
        }
        public override string getColor()
        {
            return color;
        }
    }
}