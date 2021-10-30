using System;
using System.Threading;

namespace Chapter1.Threads
{
    /// <summary>
    /// Using ThreadLocal<T>
    /// </summary>
    public class Listing1_6 : IMain
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);
        public void Run()
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0})",i);
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0})",i);
                }
            }).Start();

        }
    }
}