using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_starTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

			// Input

			int number;

            Console.Write("Enter the level of Number Triangle : ");
			number = Convert.ToInt32(Console.ReadLine());


			// Output

			for (int i = 1; i <= number; i++)
			{

				for (int j = 1; j <= (number - i); j++)
				{
					Console.Write(" ");
				}	

				for (int k = 1; k < i * 2; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine("");
			}
		}
    }
}
