using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your number: ");
        int n = int.Parse(Console.ReadLine());
        bool isEven = n % 2 == 0;
        Console.WriteLine("The number you have entered is even: " + isEven);

    }
}

