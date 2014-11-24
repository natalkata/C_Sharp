using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem1_SumOf3Numbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter three numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sum = a + b + c;
        Console.WriteLine("The sum is of {0}, {1} and {2} is {3}", a, b, c, sum);
    }
}

