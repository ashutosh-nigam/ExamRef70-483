using System;
using System.Threading;

namespace Chapter1.Threads
{
    /// <summary>
    /// Using a ParameterizedThreadStart
    /// </summary>
    public class Listing1_3:IMain
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
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}