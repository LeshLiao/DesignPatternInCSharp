﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context myContext = new Context(new ConcreteStateA());
            myContext.SwitchRequest();
            myContext.SwitchRequest();
            myContext.SwitchRequest();
            myContext.SwitchRequest();
            myContext.SwitchRequest();
            myContext.SwitchRequest();

            Console.ReadKey();
        }
    }
}
