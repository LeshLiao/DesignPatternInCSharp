using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public abstract class Brush
    {
        protected Color _color;
        public abstract void Paint();
        public void SetColor(Color color)
        { 
            this._color = color; 
        }
    }
}