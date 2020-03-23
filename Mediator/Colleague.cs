using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediator
{
    public abstract class Colleague
    {
        public Mediator _mediator;

        public abstract void Send(string msg);
        public abstract void Notify(string msg);
    }
}