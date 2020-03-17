using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon _weapon = new Sword("Mary");
            //Weapon _weapon = new Knife("Jack");
            var _long = new Long();
            var _sharp = new Sharp();
            var _beautiful = new Beautiful();

            _long.Decorate(_weapon);
            _sharp.Decorate(_long);
            _beautiful.Decorate(_sharp);

            _beautiful.Show();  //print message by recursive 
            Console.WriteLine("Attack Power="+ _beautiful.GetAttackPower().ToString());

            Console.Read();
        }
    }
}
