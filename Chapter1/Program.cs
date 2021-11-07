using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Chapter1.AsyncAwait;
using Chapter1.Parallels;
using Chapter1.Tasks;
using Chapter1.Threads;

namespace Chapter1
{

    public class Program
    {
        public static void Main()
        {
            try
            {
                IMain m = new Listing1_18();

                m.Run();
                //var summary = BenchmarkRunner.Run(typeof(Program).Assembly);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Chapter 1 Exam Ref 70-486");
            }
        }
    }
}