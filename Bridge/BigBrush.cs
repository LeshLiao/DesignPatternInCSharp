using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class BigBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("Using big brush and color {0} painting", _color.getColor());
        }
    }
}