using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position: ");
        int p = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << p;
        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}

