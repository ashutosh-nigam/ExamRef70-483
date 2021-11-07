using System;
using System.Linq;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// using ForAll
    /// </summary>
    public class Listing1_26 : IMain
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}