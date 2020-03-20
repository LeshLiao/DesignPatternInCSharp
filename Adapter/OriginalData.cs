using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class OriginalData : Compound
    {
        public OriginalData(string name)
          : base(name)
        {
        }

        public override void Display()
        {
            base.Display();
            if (base._chemical.Equals("Oxygen"))
            {
                Console.WriteLine(" Formula: {0}", "O2");
                Console.WriteLine(" Weight : {0}","15.999");
                Console.WriteLine(" Melting Pt: {0}","-218.79");
                Console.WriteLine(" Boiling Pt: {0}","-182.962");
            }
        }
    }
}