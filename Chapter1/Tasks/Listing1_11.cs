using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Chapter1.Tasks
{
    public class Listing1_11  : IMain
    {
        public void Run()
        {
            var t = Task.Run(() => 42);
            t.ContinueWith((i) => Console.WriteLine("Cancelled"), TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) => Console.WriteLine("Faulted"), TaskContinuationOptions.OnlyOnFaulted);
            var completedTask= t.ContinueWith((i) => Console.WriteLine("Completed"), TaskContinuationOptions.OnlyOnRanToCompletion);
            completedTask.Wait();
        }
    }
}