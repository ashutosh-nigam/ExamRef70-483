using System;
using System.Threading;

namespace Chapter1
{
    /// <summary>
    /// Using a ThreadStaticAttribute
    /// </summary>
    public class Listing1_5 : IMain
    {
        [ThreadStatic]
        public static int _field;
        public void Run()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"thread A: {_field}");
                }
            }).Start();
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"thread B: {_field}");
                }
            }).Start();
            //Console.ReadKey();
        }
    }
}