using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethod
{
    public abstract class Beverage
    {
        public Beverage()
        {
            Console.WriteLine("Let me think...(Beverage constructor)");
        }

        public virtual void BoilWater()
        {
            Console.WriteLine("Heating the Water");
        }
        public abstract void Brew();
        public virtual void PourInCup()
        {
            Console.WriteLine("Pour the beverage into the mug");
        }
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
        }
    }
}