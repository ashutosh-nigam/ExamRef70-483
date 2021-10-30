using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.Parallels
{
    /// <summary>
    /// Using Parallel.For and Prallel.Foreach
    /// </summary>
    public class Listing1_16 : IMain
    {
        public void Run()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine($"Parallel For : {i}");
                Thread.Sleep(1000);
            });
            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine($"Parallel Foreach: {i}");
                Thread.Sleep(1000);
            });
        }
    }
}