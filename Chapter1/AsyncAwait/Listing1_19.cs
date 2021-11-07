using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1.AsyncAwait
{
    /// <summary>
    /// Scalability versus responsiveness
    /// </summary>
    public class Listing1_19 : IMain
    {
        public void Run()
        {
            SleepAsyncA(1000);
            SleepAsyncB(1000);
        }

        public Task SleepAsyncA(int millisecondsTimeout)
        {
            Console.WriteLine("SleepAsyncA");
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public Task SleepAsyncB(int millisecondsTimeout)
        {
            Console.WriteLine("SleepAsyncB");
            TaskCompletionSource<bool> tsc = null;
            var t = new Timer(delegate { tsc.TrySetResult(true); }, null, -1, -1);
            tsc = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tsc.Task;
        }
    }
}