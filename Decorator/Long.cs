using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Long : StrengthenDecorator
    {
        public override void Show()
        {
            Console.Write("Long ");
            base.Show();
        }
        public override double GetAttackPower()
        {
            return base.GetAttackPower() + 5;
        }
    }
}