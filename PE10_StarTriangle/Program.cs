using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE10_StarTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

			// Input

			int level;

			Console.Write("Enter the level of Star Triangle : ");
			level = Convert.ToInt32(Console.ReadLine());


			// Output

			// For level
			for (int i = 1; i <= level; i++)
			{

				// For space
				for (int j = 1; j <= (level - i); j++)
				{
					Console.Write(" ");
				}

				// For *
				for (int k = 1; k < i * 2; k++)
				{
					Console.Write("*");
				}

				Console.WriteLine();
			}

            Console.WriteLine();
		}
    }
}
