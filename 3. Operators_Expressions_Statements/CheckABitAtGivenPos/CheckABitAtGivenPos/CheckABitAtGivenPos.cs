using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class CheckABitAtGivenPos
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position: ");
        int p = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << p;
        bool isOne = ((n & mask) != 0 ? 1 : 0) == 1;
        Console.WriteLine("The bit at position {0} is 1: {1}", p, isOne);
    }
}

