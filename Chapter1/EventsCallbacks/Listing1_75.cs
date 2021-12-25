using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.EventsCallbacks
{
    internal class Listing1_75 : IMain
    {
        public delegate int Calculate(int x, int y);

        public int Add(int x, int y) => x + y;
        public int Multiply(int x, int y) => x * y;

        public void Run()
        {
            Calculate calculate = Add;
// Console.WriteLine(calculate(3,4));
            calculate += Multiply;
            Console.WriteLine(calculate(3,4));
        }
    }
}
