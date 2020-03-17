using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class Tea : Beverage
    {
        public Tea()
        {
            Console.WriteLine("(Tea constructor)");
        }
        public override void Brew()
        {
            Console.WriteLine("Place tea leaves or bags into the teapot or cup.");
        }
    }
}