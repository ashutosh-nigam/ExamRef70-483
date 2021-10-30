using System;
using System.Threading.Tasks;

namespace Chapter1.Tasks
{
    /// <summary>
    /// Task That returns a value and Adding a continuation
    /// </summary>
    public class Listing1_10 : IMain
    {
        public void Run()
        {
            Task<int> t = Task.Run(() =>42)
                .ContinueWith((i)=> i.Result *2);
            Console.WriteLine(t.Result);
        }
    }
}