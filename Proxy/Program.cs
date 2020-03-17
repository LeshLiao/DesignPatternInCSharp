using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        internal IPrintable IPrintable
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {
            IPrintable p = new PrinterProxy("Alice");
            Console.WriteLine("現在的名稱是" + p.getPrinterName() + "。");
            p.setPrinterName("Bob");
            Console.WriteLine("現在的名稱是" + p.getPrinterName() + "。");
            p.print("Hello, world.1");

            p.print("Hello, world.2");
            p.print("Hello, world.3");

            Console.ReadLine();
        }
    }
}
