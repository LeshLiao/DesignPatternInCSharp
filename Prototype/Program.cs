using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("Jack");
            a.SetWorkExperience(18,"2020","AA.INC");
            a.Display();

            Resume b = a.DeepCopy();
            b.SetCompany("BB.INC");
            b.Display();

            a.Display();

            Console.ReadLine();

        }
    }
}
