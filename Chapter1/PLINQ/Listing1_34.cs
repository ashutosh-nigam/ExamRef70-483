using System;
using System.Collections.Concurrent;

namespace Chapter1.PLINQ
{
    public class Listing1_34:IMain
    {
        public void Run()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if(dict.TryAdd("k1",42))
                Console.WriteLine("Added 42");
            if(dict.TryUpdate("k1",21,42))
                Console.WriteLine("42 updated to 21");

            dict["k1"] = 42;
            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("K2", 3);
            Console.WriteLine($"R1: {r1.ToString()} \nR2: {r2.ToString()}");
        }
    }
}