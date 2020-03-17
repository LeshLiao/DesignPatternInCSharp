using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class AmericaFactory : ContinentFactory
    {
        private Wolf _wolf;
        public override Carnivore CreateCarnivore()
        {
            _wolf = new Wolf();
            return _wolf;
        }
    }
}