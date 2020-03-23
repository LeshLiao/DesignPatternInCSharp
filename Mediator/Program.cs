using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator _mediator = new ConcreteMediator();
            ConcreteColleague1 _concrete01 = new ConcreteColleague1(_mediator);
            ConcreteColleague2 _concrete02 = new ConcreteColleague2(_mediator);
            _mediator.Colleague1 = _concrete01;
            _mediator.Colleague2 = _concrete02;

            _concrete01.Send("Hi,there!");

            _concrete02.Send("Great things will come! We know it!");

            Console.ReadKey();
        }
    }
}
