using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Loggers;

namespace Chapter1.EventsCallbacks
{
    
    internal class Listing1_87 : IMain
    {
        public class Pub
        {
            public event EventHandler OnChange= delegate { };
            public void Raise()
            {
                var exceptions = new List<Exception>();
                foreach (Delegate handler in OnChange.GetInvocationList())
                {
                    try
                    {
                        handler.DynamicInvoke(this, EventArgs.Empty);
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                if (exceptions.Any())
                {
                    throw new AggregateException(exceptions);
                }
            }
        }
        public void Run()
        {
            Pub p = new Pub();
            p.OnChange += (sender, args) => Console.WriteLine("Subscriber 1 Called");
            p.OnChange += (sender, args) => { throw new Exception(); };
            p.OnChange += (sender, args) => Console.WriteLine("Subscriber 3 called");
            try
            {
                p.Raise();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions.Count);
                
            }
        }
    }
}
