using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator _med)
        {
            _mediator = _med;
        }
        public override void Send(string msg)
        {
            _mediator.Send(this, msg);
        }
        public override void Notify(string msg)
        {
            Console.WriteLine("Colleague2 receive:" + msg);
        }
    }
}