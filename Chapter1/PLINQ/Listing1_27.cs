using System;
using System.Linq;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Caching AggregateException
    /// </summary>
    public class Listing1_27 : IMain
    {
        public void Run()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel().Where(i => IsEven(i));
                parallelResult.ForAll(x => Console.WriteLine(x));
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"no of Exceptions: {e.InnerExceptions.Count}");
            }
        }

        private static bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException(i.ToString());
            return i % 2 == 0;
        }
    }
}