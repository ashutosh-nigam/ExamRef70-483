using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.EventsCallbacks
{
    internal class Listing1_76 : IMain
    {
        public delegate void MulticastDel();
        public void MethodOne() => Console.WriteLine("Method 1");
        public void MethodTwo() => Console.WriteLine("Method 2");
        public void Run()
        {
            MulticastDel m = MethodOne;
            m += MethodTwo;
            m();
        }
    }
}
