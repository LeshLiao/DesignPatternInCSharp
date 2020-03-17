using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Knife : Weapon
    {
        public Knife(string user)
        {
            userName = user;
        }
        public override void Show()
        {
            Console.WriteLine("Knife is belong to " + userName);
        }
        public override double GetAttackPower()
        {
            return 5;
        }
    }
}