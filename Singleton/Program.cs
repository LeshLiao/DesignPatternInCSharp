using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LoadBalancer:");
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance");
            }

            //第一次使用時，才產生實例
            Console.WriteLine("Lazy singleton:");
            Singleton_LazyInitialization S1 = Singleton_LazyInitialization.GetInstance();
            Singleton_LazyInitialization S2 = Singleton_LazyInitialization.GetInstance();
            if (S1 == S2)
            {
                Console.WriteLine("Same instance");
            }

            //class 載入時，即產生實例
            Console.WriteLine("Eager singleton:");
            Singleton_EagerInitialization S3 = Singleton_EagerInitialization.GetInstance();
            Singleton_EagerInitialization S4 = Singleton_EagerInitialization.GetInstance();
            if (S3 == S4)
            {
                Console.WriteLine("Same instance");
            }

            Console.ReadKey();
        }
    }
}
