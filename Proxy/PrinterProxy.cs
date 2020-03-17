using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class PrinterProxy : IPrintable
    {
        private readonly object printerLock = new object();
        private String name;
        private Printer real;
        public PrinterProxy(String name)
        {
            this.name = name;
        }

        internal Printer Printer
        {
            get => default;
            set
            {
            }
        }

        public void setPrinterName(String name)
        {
            lock (printerLock)
            {
                if (real != null)
                {
                    real.setPrinterName(name);
                }
            }
            this.name = name;
        }

        public String getPrinterName()
        {
            return name;
        }
        public void print(String str)
        {
            lock (printerLock)
            {
                if (real == null)
                {
                    real = new Printer(name);
                }
            }
            real.print(str);
        }
    }
}
