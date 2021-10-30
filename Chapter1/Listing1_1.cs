using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// Creating Thread with Thread Class
    /// </summary>
    class Listing1_1:IMain
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(0);
            }
        }

        public void Run()
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (var i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread: do some work.");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}