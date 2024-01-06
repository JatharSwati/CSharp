﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9_NumberTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int i, j, k, l, n;

            Console.Write("Enter the number of rows : ");
            n = int.Parse(Console.ReadLine());


            // Output

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
