using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class MyItem
    {
        private string _name;

        // Constructor

        public MyItem(string name)
        {
            this._name = name;
        }

        // Gets name

        public string Name
        {
            get { return _name; }
        }
    }
}
