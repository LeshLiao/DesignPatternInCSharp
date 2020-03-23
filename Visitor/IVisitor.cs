using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}