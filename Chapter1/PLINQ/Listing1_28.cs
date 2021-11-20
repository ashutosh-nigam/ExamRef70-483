using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Chapter1.PLINQ
{
    /// <summary>
    /// Using BlockingCollection<![CDATA[>nigam]]>
    /// </summary>
    public class Listing1_28 : IMain
    {
        public void Run()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                while (true)
                    Console.WriteLine(col.Take());
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