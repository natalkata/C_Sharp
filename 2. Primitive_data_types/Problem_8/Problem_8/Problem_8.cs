using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_8
{
    class Problem_8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyRight = '\u00A9';
            char space = (char)0;
            int rows = 3;
            int columns = 5;
            int cSymbol = 1;

            for (int i = 0; i < rows; i++)
            {
                for (int blank = 0; blank < columns - i; blank++)
                {
                    Console.Write(space);
                }
                for (int symbol = 0; symbol < cSymbol; symbol++)
                {
                    Console.Write(copyRight);
                }

                cSymbol += 2;
                Console.WriteLine();
            }
        }
    }
}
