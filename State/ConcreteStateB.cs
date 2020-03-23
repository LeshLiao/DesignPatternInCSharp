using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class ConcreteStateB : State
    {
        public ConcreteStateB()
        {
        }
        public ConcreteStateB(State state) : this(state.number)
        {
        }

        public ConcreteStateB(int _number)
        {
            this.number = _number + 1;
        }
        public override void Request(Context _context)
        {
            Console.WriteLine("ConcreteStateB:" + number.ToString());
            _context.setState(new ConcreteStateA(this));
        }
    }
}