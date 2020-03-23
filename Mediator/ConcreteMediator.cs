using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;
        public ConcreteColleague1 Colleague1 
        {
            set { _colleague1 = value; }
        }
        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }
        public override void Send(Colleague _from,string msg)
        {
            if(_from == _colleague1)
            {
                _colleague2.Notify(msg);
            }
            else if(_from == _colleague2)
            {
                _colleague1.Notify(msg);
            }
        }
    }
}