using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExtractBitN3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        int i = 1;
        int mask = i << 3;
        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}

