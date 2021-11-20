using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Using a Concurrent Stack
    /// </summary>
    public class Listing1_32 : IMain
    {
        public void Run()
        {
            var stack = new ConcurrentStack<int>();
            stack.Push(42);
            int result;
            if (stack.TryPop(out result))
                Console.WriteLine("Popped Out : {0}",result.ToString());
            stack.PushRange(new int[] {1, 2, 3});
            int[] values = new int[2];
            stack.TryPopRange(values);
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}