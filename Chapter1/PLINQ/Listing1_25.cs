using System;
using System.Linq;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Making a parallel query sequential
    /// </summary>
    public class Listing1_25 : IMain
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(x => x % 2 == 0).AsSequential();
            foreach (var i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}