using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9
{
    class Problem_9
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
