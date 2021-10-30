using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// Stopping a thread
    /// </summary>
    public class Listing1_4 : IMain
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(0);
            }
        }
        
        public void Run()
        {
            var stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));
            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            t.Join();
        }
    }
}