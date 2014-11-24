using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, 
//on a single line, separated by a space
class Problem2_NumbersNotDevisibleBy3And7
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            if ((i % 7 == 0) || (i % 3 == 0))
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

