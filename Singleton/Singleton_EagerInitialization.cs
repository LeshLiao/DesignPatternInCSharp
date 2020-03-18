using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton_EagerInitialization
    {
        private static readonly Singleton_EagerInitialization instance = new Singleton_EagerInitialization();
        private Singleton_EagerInitialization()
        {

        }
        public static Singleton_EagerInitialization GetInstance()
        {
            return instance;
        }
    }
}
