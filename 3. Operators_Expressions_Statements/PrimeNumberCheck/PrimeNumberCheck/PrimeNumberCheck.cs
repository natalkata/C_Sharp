using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your number:");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (num == 1)
        {
            isPrime = false;
            Console.WriteLine("This number is prime: " + isPrime);
        }
        else
        {
            int counter = 0;
            for (int i = 1; i <= 0 ; i++)
            {
                if (num % i == 0)
                {
                    counter = counter + 1;
                }

                if (counter > 2)
                {
                    isPrime = false;
                }
            }

            Console.WriteLine("The number is prime: " + isPrime);
        }
    }
}

