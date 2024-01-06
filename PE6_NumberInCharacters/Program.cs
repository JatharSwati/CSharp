using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE6_NumberInCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input

            int number, reverseNumber = 0, reminder;

            Console.Write("Enter your number : ");
            number = int.Parse(Console.ReadLine());


            // Output

            Console.WriteLine();

            while (number > 0)
            {
                reminder = number % 10;
                number = number / 10;
                reverseNumber = reverseNumber * 10 + reminder;
            }
            number = reverseNumber;
            while (number > 0)
            {
                reminder = number % 10;
                switch (reminder)
                {
                    case 1:
                        Console.Write("one ");
                        break;
                    case 2:
                        Console.Write("two ");
                        break;
                    case 3:
                        Console.Write("three ");
                        break;
                    case 4:
                        Console.Write("four ");
                        break;
                    case 5:
                        Console.Write("five ");
                        break;
                    case 6:
                        Console.Write("six ");
                        break;
                    case 7:
                        Console.Write("seven ");
                        break;
                    case 8:
                        Console.Write("eight ");
                        break;
                    case 9:
                        Console.Write("nine ");
                        break;
                    case 0:
                        Console.Write("zero ");
                        break;
                    default:
                        Console.Write("tttt ");
                        break;
                }                                       //end of switch      

                number = number / 10;

            }                                           //end of while loop       

            Console.WriteLine("\n");

        }
    }
}
