using System;
using System.Collections.Concurrent;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Concurrent Queue
    /// </summary>
    public class Listing1_33 :IMain
    {
        public void Run()
        {
            var queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
            {
                Console.WriteLine($"Dequeued: {result.ToString()}");
            }
        }
    }
}