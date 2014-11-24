using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem5_Faktoriel
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter N=");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X=");
        int X = int.Parse(Console.ReadLine());
        double rezult = 1.00;
        double FaktSum = 1.00;
        double tempDelitel = 1.00;
        for (int i = 1; i <= n; i++)
        {
            // double factorial = 0.0;
            FaktSum *= i;
            tempDelitel = tempDelitel * n;
            rezult += FaktSum / tempDelitel;

        }

        Console.WriteLine(rezult);
    }
}

