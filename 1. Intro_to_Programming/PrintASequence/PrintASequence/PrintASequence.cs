using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class PrintASequence
{
    static void Main(string[] args)
    {
        int j = 2;
        for (int i = 0; i < 10; i++)
        {
            if (j%2==1)
            {
                if ( i == 9)
                {
                    Console.WriteLine("-" + j);
                }
                else
                {
                    Console.Write("-" + j + ",");
                }
                
            }
            else
            {
                if (i == 9)
                {
                    Console.WriteLine(j);
                }
                else
                {
                    Console.Write(j + ",");
                }
                
            };
            j = j + 1;
        }
    }
}

