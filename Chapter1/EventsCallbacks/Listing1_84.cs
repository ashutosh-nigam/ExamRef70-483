using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.EventsCallbacks
{
    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
    public class Pub_Listing1_84
    {
        public event EventHandler<MyArgs> OnChange = delegate { };
        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }
    internal class Listing1_84 : IMain
    {
        public void Run()
        {
            Pub_Listing1_84 p = new Pub_Listing1_84();
            p.OnChange += (sender, e) => Console.WriteLine($"Event Raised : {e.Value}");
            p.Raise();
        }
    }
}
