using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Using GetConsumingEnumerable on a BlockingCollection
    /// </summary>
    public class Listing1_29 : IMain
    {
        

        public void Run()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
             {
                 foreach (var s in col.GetConsumingEnumerable())
                 {
                     Console.WriteLine(s);
                 }
             });
            Task write = Task.Run(() =>
             {
                 while (true)
                 {
                     string s = Console.ReadLine();
                     if (string.IsNullOrEmpty(s)) break;
                     col.Add(s);
                 }
             });
            write.Wait();
        }
    }
}
