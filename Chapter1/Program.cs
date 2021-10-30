using System;
using Chapter1.Threads;

namespace Chapter1
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                IMain m = new Listing1_7();

                m.Run();
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