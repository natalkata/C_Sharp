using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem9_SumOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is ---> " + sum);
    }
}

