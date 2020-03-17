using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IPrintable
    {
        void setPrinterName(string name);   // 命名
        string getPrinterName();            // 取得名稱
        void print(string str);          // 輸出字串（列印）
    }
}
