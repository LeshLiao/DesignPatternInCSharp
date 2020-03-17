using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Proxy
{
    class Printer:IPrintable
    {
        private string name;
        public Printer()
        {
            heavyJob("正在產生Printer的物件個體");
        }
        public Printer(string name)
        {                   // 建構子
            this.name = name;
            heavyJob("正在產生Printer的物件個體(" + name + ")");
        }
        public void setPrinterName(string name)
        {       // 命名
            this.name = name;
        }
        public string getPrinterName()
        {                // 取得名稱
            return name;
        }
        public void print(string str)
        {              // 輸出名稱
            Console.WriteLine("=== " + name + " ===");
            Console.WriteLine(str);
        }
        private void heavyJob(string msg)
        {             // 較重的工作（假設）
            Console.WriteLine(msg);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("完成。");
        }
    }
}
