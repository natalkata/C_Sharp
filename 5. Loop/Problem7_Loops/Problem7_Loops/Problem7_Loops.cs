using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem7_Loops
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int FactorielN = 1;
        int FactorielK = 1;
        int FactorielNK = 1;
        if (k >= n)
        {
            Console.WriteLine("Please enter k lower than n:");
            k = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= n; i++)
        {
            FactorielN = FactorielN * i;
        }
        for (int i = 1; i <= k; i++)
        {
            FactorielK = FactorielK * i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            FactorielNK = FactorielNK * i;
        }
        int Combo = FactorielN/(FactorielK*FactorielNK);
        Console.WriteLine(Combo);
    }
}

