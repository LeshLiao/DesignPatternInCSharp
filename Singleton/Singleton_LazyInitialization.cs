using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton_LazyInitialization
    {
        private static readonly object thisLock = new object();
        private static Singleton_LazyInitialization instance;
        private Singleton_LazyInitialization()
        {

        }
        public static Singleton_LazyInitialization GetInstance()
        {
            if (null == instance)
            {
                lock (thisLock)
                {
                    if (null == instance)
                    {
                        instance = new Singleton_LazyInitialization();
                    }
                }
            }
            return instance;
        }
    }
}
