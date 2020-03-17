using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class Weapon
    {
        //protected int attackPower;
        public string userName;
        public abstract void Show();
        public abstract double GetAttackPower();
    }
}