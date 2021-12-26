using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Concurrent Bag
    /// </summary>
    public class Listing1_31 : IMain
    {
        public void Run()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });
            Task.Run(() =>
            {
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();

        }
    }
}