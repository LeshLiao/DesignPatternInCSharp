using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interpreter
{
    public abstract class AbstractExpression
    {
        public abstract void Evaluate(Context context);
    }
}