using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class Red : Color
    {
        public Red()
        { 
            this.color = "Red"; 
        }
        public override string getColor()
        {
            return color;
        }
    }
}