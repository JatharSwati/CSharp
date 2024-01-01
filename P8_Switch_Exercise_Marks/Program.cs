using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8_Switch_Exercise_Marks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            float marathi, english, physics, chemistry, mathematics, biology;

            Console.WriteLine("Enter your subjects marks - ");

            Console.Write("\nMarathi : ");
            marathi = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnglish : ");
            english = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPhysics : ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nChemistry : ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nMathematics : ");
            mathematics = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nBiology : ");
            biology = Convert.ToInt32(Console.ReadLine());

            // Output

            float subject = 4;
            switch(subject)
            {
                case 1:
                    Console.WriteLine($"\nYour marathi marks is {marathi}.");
                    break;
                case 2:
                    Console.WriteLine($"\nYour english marks is {english}.");
                    break;
                case 3:
                    Console.WriteLine($"\nyour physics marks is {physics}.");
                    break;
                case 4:
                    Console.WriteLine($"\nYour chemistry marks is {chemistry}.");
                    break;
                case 5:
                    Console.WriteLine($"\nYour mathematics marks is {mathematics}.");
                    break;
                case 6:
                    Console.WriteLine($"\nYour biology marks is {biology}.");
                    break;
            }

            Console.WriteLine();

        }
    }
}
