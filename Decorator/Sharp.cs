using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Sharp : StrengthenDecorator
    {
        public override void Show()
        {
            Console.Write("Sharp ");
            base.Show();
        }
        public override double GetAttackPower()
        {
            return base.GetAttackPower() + 20;
        }
    }
}