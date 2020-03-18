using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 

        // immediately when class is loaded for the first time.

        // .NET guarantees thread safety for static initialization

        private static readonly LoadBalancer _instance = new LoadBalancer();

        private LoadBalancer()
        {

        }
        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }
    }
}
