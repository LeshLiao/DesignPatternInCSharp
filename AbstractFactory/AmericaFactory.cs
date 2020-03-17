using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class AmericaFactory : ContinentFactory
    {
        private Bison _bison;
        private Wolf _wolf;
        public override Herbivore CreateHerbivore()
        {
            _bison = new Bison();
            return _bison;
        }
        public override Carnivore CreateCarnivore()
        {
            _wolf = new Wolf();
            return _wolf;
        }
    }
}