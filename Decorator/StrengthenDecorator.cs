using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public abstract class StrengthenDecorator : Weapon
    {
        protected Weapon _weapon;
        public void Decorate(Weapon weapon)
        {
            _weapon = weapon;
        }
        public override void Show()
        {
            if (_weapon != null)
            {
                _weapon.Show();
            }
        }
        public override double GetAttackPower()
        {
            return _weapon.GetAttackPower();
        }
    }
}