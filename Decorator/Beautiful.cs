using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Beautiful : StrengthenDecorator
    {
        public override void Show()
        {
            Console.Write("Beautiful ");
            base.Show();
        }
        public override double GetAttackPower()
        {
            return base.GetAttackPower() + 0;
        }
    }
}