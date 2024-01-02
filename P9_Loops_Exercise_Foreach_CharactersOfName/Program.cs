using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_Loops_Exercise_Foreach_CharactersOfName
{
    class Program
    {
        static void Main(string[] args)
        {           

            string name;

            Console.Write("Enter your name : ");
            name = Console.ReadLine();

            foreach (char c in name)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();

        }
    }
}
