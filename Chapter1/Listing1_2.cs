using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// Using a Background Thread
    /// </summary>
    public class Listing1_2:IMain
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}",i);
                Thread.Sleep(1000);
            }
        }

        public void Run()
        {
            var t = new Thread(new ThreadStart(ThreadMethod));
                        t.IsBackground = true;
                        t.Start();
        }
    }
}