using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class AfricaFactory : ContinentFactory
    {
        private Wildebeest _wildebeest;
        private Lion _lion;
        public override Herbivore CreateHerbivore()
        {
            _wildebeest = new Wildebeest();
            return _wildebeest;
        }
        public override Carnivore CreateCarnivore()
        {
            _lion = new Lion();
            return _lion;
        }
    }
}