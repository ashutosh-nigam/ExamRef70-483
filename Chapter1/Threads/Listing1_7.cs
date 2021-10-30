using System;
using System.Threading;

namespace Chapter1.Threads
{
    /// <summary>
    /// Queuing some work to the thread pool
    /// </summary>
    public class Listing1_7 :IMain
    {
        public void Run()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from thredpool");
            });
            Console.ReadLine();
        }
    }
}