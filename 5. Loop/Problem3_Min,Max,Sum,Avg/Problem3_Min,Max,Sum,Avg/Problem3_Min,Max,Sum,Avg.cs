using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Problem3_Min_Max_Sum_Avg
{
    static void Main(string[] args)
    {
        Console.WriteLine("How many numbers you would like to enter:");
        int n = int.Parse(Console.ReadLine());
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        int min = num;
        int max = num;
        for (int i = 0; i < n - 1; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (min > num)
            {
                min = num;
            }
            if (max < num)
            {
                max = num;
            }
            sum = sum + num;

        }
        double avg = sum / 2.0;
        Console.WriteLine("Min number is: " + min);
        Console.WriteLine("Max number is: " + max);
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The avarage number is: " + avg);
    }
}

