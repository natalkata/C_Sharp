using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_6
{
    class Problem_6
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object concat = first + " " + second;
            string wholeString = concat.ToString();
            Console.WriteLine(wholeString);
        }
    }
}
