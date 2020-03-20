using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class SmallBrush : Brush
    {
        public override void Paint()
        {
            Console.WriteLine("Using small brush and color {0} painting", _color.getColor());
        }
    }
}