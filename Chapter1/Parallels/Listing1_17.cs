using System;
using System.Threading.Tasks;

namespace Chapter1.Parallels
{
    /// <summary>
    /// Using Parallel.Break
    /// </summary>
    public class Listing1_17 : IMain
    {
        public void Run()
        {
            var result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i != 500)
                {
                    Console.WriteLine($"{i}");
                    return;
                }
                Console.WriteLine("Breaking loop");
                loopState.Break();

                return;
            });
        }
    }
}