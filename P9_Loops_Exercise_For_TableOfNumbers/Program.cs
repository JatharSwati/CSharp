using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loops_Exercise_For_TableOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.Write("Enter your number to make table : ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine(i * num);
            }

            Console.WriteLine();

        }
    }
}
