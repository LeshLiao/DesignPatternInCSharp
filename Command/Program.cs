using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static User user;
        static void Main(string[] args)
        {
            user = new User();
            /*
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            user.Undo(4);

            user.Compute('+', 100);
            user.Compute('+', 100);
            user.Compute('+', 100);
            user.Undo(3);
            */

            user.Compute('+', 100);
            user.Undo(1);
            user.Compute('+', 50);
            user.Undo(1);


            Console.ReadKey();
        }
    }
}
