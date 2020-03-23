using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class ConcreteStateA : State
    {
        public ConcreteStateA() 
        {
        }
        public ConcreteStateA(State state) : this(state.number)
        {
        }

        public ConcreteStateA(int _number)
        {
            this.number = _number+1;
        }
        public override void Request(Context _context)
        {
            Console.WriteLine("ConcreteStateA:"+number.ToString());
            _context.setState(new ConcreteStateB(this));
        }
    }
}