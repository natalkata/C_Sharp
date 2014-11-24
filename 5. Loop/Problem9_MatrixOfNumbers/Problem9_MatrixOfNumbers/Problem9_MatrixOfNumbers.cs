using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem9_MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int num = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                if (j == 1)
                {
                    num = i + 1;
                }
                else
                {
                    num = num + 1;
                }
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}

