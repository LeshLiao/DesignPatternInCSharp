using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class AfricaFactory : ContinentFactory
    {
        private Lion _lion;
        public override Carnivore CreateCarnivore()
        {
            _lion = new Lion();
            return _lion;
        }
    }
}