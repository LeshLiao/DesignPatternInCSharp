using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Compound> chemicalList = new List<Compound>();

            Console.WriteLine("Add Non-adapted chemical:Oxygen");
            chemicalList.Add(new OriginalData("Oxygen"));

            Console.WriteLine("Adapted chemical compounds:Water,Benzene,Ethanol");
            chemicalList.Add(new RichCompound("Water"));
            chemicalList.Add(new RichCompound("Benzene"));
            chemicalList.Add(new RichCompound("Ethanol"));

            Console.WriteLine("Show all chemical compounds"); 
            foreach (var item in chemicalList)
            {
                item.Display();
            }

            Console.ReadKey();
        }
    }
}
