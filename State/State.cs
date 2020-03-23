using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    public abstract class State
    {
        public int number;
        public abstract void Request(Context context);
    }
}