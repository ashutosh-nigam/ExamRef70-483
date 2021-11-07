using System;
using System.Net.Http;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Chapter1.AsyncAwait
{
    /// <summary>
    /// Async And Await
    /// </summary>
    public class Listing1_18 : IMain
    {
        public static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("https://www.microsoft.com");
                return result;
            }
        }
        //[Benchmark]
        public void Run()
        {
            Console.WriteLine("Start");
            var result = DownloadContent().Result;
            Console.WriteLine(result);
        }
    }
}