using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem10_FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            int first = 0;
            int second = 1;
            int third = 0;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 2; i < n; i++)
            {
                third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
        }
       
    }
}

