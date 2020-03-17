using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ContinentFactory firstFactory = new AfricaFactory();
            Carnivore firstAnimal = firstFactory.CreateCarnivore();
            Console.WriteLine($"You could see {firstAnimal.GetType().Name} In Africa.");

            ContinentFactory secondFactory = new AmericaFactory();
            Carnivore secondAnimal = secondFactory.CreateCarnivore();
            Console.WriteLine($"You could see {secondAnimal.GetType().Name} In America.");

            Console.ReadLine();
        }
    }
}
