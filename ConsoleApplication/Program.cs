using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuff();
        }

        private static void DoStuff()
        {
            IEnumerable<int> enumerable = Enumerable.Range(0, 100);
            foreach (var i in enumerable)
            {
                Console.WriteLine("value = {0}", i);
            }
        }
    }
}
