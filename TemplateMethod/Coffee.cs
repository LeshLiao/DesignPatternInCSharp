using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public class Coffee : Beverage
    {
        public Coffee()
        {
            Console.WriteLine("(Coffee constructor)");
        }
        public override void Brew()
        {
            Console.WriteLine("Dissolve the coffee with a tablespoon of cold water.");
        }
    }
}