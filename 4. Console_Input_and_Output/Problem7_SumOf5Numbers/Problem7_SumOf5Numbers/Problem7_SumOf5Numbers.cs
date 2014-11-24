using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem7_SumOf5Numbers
{
    static void Main(string[] args)
    {
        string inputNums = Console.ReadLine();
        inputNums = inputNums.Replace(',', '.');
        decimal sum = 0.00m;
        string[] numbersAsStrings = inputNums.Split(' ');
        for (int i = 0; i < numbersAsStrings.Length; i++)
        {
            sum += decimal.Parse(numbersAsStrings[i]);
        }
        Console.WriteLine(sum);
    }
}

