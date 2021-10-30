using System;
using System.Threading.Tasks;

namespace Chapter1.Tasks
{
    /// <summary>
    /// Starting a new Task
    /// </summary>
    public class Listing1_8 : IMain
    {
        public void Run()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine("*");
                }
            });
            t.Wait();
        }
    }
}