using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;


class Problem8_CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger FactorielN = 1;
        BigInteger FactorielTwiceN = 1;
        for (int i = 1; i <= n; i++)
        {
            FactorielN = FactorielN * i;
        }
        for (int i = (2 * n); i > (n + 1)  ; i--)
        {
            FactorielTwiceN = FactorielTwiceN * i;
        }
        BigInteger CatalaNum = FactorielTwiceN / (FactorielN);
        Console.WriteLine(CatalaNum);
    }
}

