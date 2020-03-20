using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush brush = new BigBrush();
            brush.SetColor(new Red());
            brush.Paint();
            brush.SetColor(new Blue());
            brush.Paint();
            brush.SetColor(new Green());
            brush.Paint();

            brush = new SmallBrush();
            brush.SetColor(new Red());
            brush.Paint();
            brush.SetColor(new Blue());
            brush.Paint();
            brush.SetColor(new Green());
            brush.Paint();

            Console.ReadLine();
        }
    }
}
