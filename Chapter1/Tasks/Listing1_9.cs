using System;
using System.Threading.Tasks;

namespace Chapter1.Tasks
{
    /// <summary>
    /// Task That returns a value
    /// </summary>
    public class Listing1_9 : IMain
    {
        public void Run()
        {
            Task<int> t = Task.Run(() =>42);
            Console.WriteLine(t.Result);
        }
    }
}