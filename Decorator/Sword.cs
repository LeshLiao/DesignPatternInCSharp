using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Sword : Weapon
    {
        public Sword(string user)
        {
            userName = user;
        }
        public override void Show()
        {
            Console.WriteLine("Sword is belong to " + userName);
        }
        public override double GetAttackPower()
        {
            return 10;
        }
    }
}