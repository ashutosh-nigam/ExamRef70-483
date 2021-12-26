using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.EventsCallbacks
{
    public class Pyb
    {
        public event EventHandler OnChange= delegate { };
        public void Raise()
        {

        }
    }
    internal class Listing1_87 : IMain
    {
        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
