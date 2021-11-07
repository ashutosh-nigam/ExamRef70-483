using System;
using System.Linq;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Unordered Parallel Query
    /// </summary>
    public class Listing1_22 : IMain
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().Where(x => x % 2 == 0).ToArray();
            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}