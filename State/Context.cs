using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public class Context
    {
        private State _state;
        public Context(State state)
        {
            this._state = state;
            this._state.number = 10;
        }
        public void setState(State newState)
        {
            _state = newState;
        }
        public void SwitchRequest()
        {
            _state.Request(this);
        }
    }
}