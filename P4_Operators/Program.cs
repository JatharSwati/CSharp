using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // Operators:
            // Operators are used to perform operations on variables and values.

            // Types of Operators:
            // 1. Arithmetic
            // 2. Assignment
            // 3. Comparison
            // 4. Logical



            // 1. Arithmetic Operators -
            // Arithmetic operators are used to perform common mathematical operations.

            int x = 8;
            int y = 4;

            Console.WriteLine("1. Arithmetic Operators - ");

            // +    Addition        Adds together two values                    x + y
            Console.WriteLine("Addition : " + (x + y));

            // -	Subtraction     Subtracts one value from another	        x - y
            Console.WriteLine("Subtraction : " + (x - y));

            // *	Multiplication  Multiplies two values	                    x * y	
            Console.WriteLine("Multiplication : " + (x * y));

            // /	Division	    Divides one value by another	            x / y
            Console.WriteLine("Division : " + (x / y));

            // %	Modulus	        Returns the division remainder	            x % y
            Console.WriteLine("Modulus : " + (x % y));

            // ++	Increment	    Increases the value of a variable by 1	    x++
            Console.WriteLine("Increment : " + (x++));

            // --	Decrement	    Decreases the value of a variable by 1	    x--
            Console.WriteLine("Decrement : " + (y--));



            // 2. Assignment Operators -
            // Assignment operators are used to assign values to variables.
            
            Console.WriteLine("\n2. Assignment Operators - ");

            // =        x = 2       x = 2
            int x1 = 2;
            Console.WriteLine("Assignment : " + (x1));

            // +=	    x += 2	    x = x + 2
            int x2 = 3;
            x2 += 2;
            Console.WriteLine("Addition assignment : " + (x2));

            // -=       x -= 1      x = x - 1
            int x3 = 4;
            x3 -= 1;
            Console.WriteLine("Subtraction assignment : " + (x3));

            // *= x     *= 2        x = x * 2
            int x4 = 5;
            x4 *= 2;
            Console.WriteLine("Multiplication assignment : " + (x4));

            // /=       x /= 3      x = x / 3
            int x5 = 6;
            x5 /= 3;
            Console.WriteLine("Division assignment : " + (x5));

            // %=       x %= 6      x = x % 6
            int x6 = 7;
            x6 %= 6;
            Console.WriteLine("Modulus assignment : " + (x6));

            // &=       x &= 2      x = x & 2
            int x7 = 8;
            x7 &= 2;
            Console.WriteLine("Bitwise AND assignment : " + (x7));

            // |=       x |= 5      x = x | 5
            int x8 = 3;
            x8 |= 5;
            Console.WriteLine("Bitwise OR assignment : " + (x8));

            // ^=       x ^= 2      x = x ^ 2
            int x9 = 7;
            x9 ^= 2;
            Console.WriteLine("Bitwise XOR assignment : " + (x9));

            // >>=      x >>= 4     x = x >> 4
            int x10 = 2;
            x10 >>= 4;
            Console.WriteLine("Right shift assignment : " + (x10));

            // <<=      x <<= 7     x = x << 7
            int x11 = 5;
            x11 <<= 7;
            Console.WriteLine("Left shift assignment : " + (x11));



            // 3. Comparison Operators -
            // Comparison operators are used to compare two values (or variables). 
            // It helps us to find answers and make decisions.
            // The return value of a comparison is either True or False. 
            // These values are known as Boolean values.

            Console.WriteLine("\n3. Comparison Operators - ");

            // ==   Equal to                    p1 == q1
            int p1 = 7;
            int q1 = 4;
            Console.WriteLine("Equal to : " + (p1 == q1));

            // !=   Not equal                   p2 != q2
            int p2 = 5;
            int q2 = 8;
            Console.WriteLine("Not equal : " + (p2 != q2));

            // >    Greater than                p3 > q3
            int p3 = 6;
            int q3 = 3;
            Console.WriteLine("Greater than : " + (p3 > q3));

            // <    Less than                   p4 < q4
            int p4 = 10;
            int q4 = 3;
            Console.WriteLine("Less than : " + (p4 < q4));

            // >=   Greater than or equal to    p5 >= q5
            int p5 = 5;
            int q5 = 6;
            Console.WriteLine("Greater than or equal to : " + (p5 >= q5));

            // <=   Less than or equal to        p6 <= q6
            int p6 = 3;
            int q6 = 3;
            Console.WriteLine("Less than or equal to : " + (p6 <= q6));



            // 4. Logical Operators - 
            // Logical operators are used to determine the logic between variables or values.

            Console.WriteLine("\n4. Logical Operators - ");

            // &&   Logical and     Returns True if both statements are true                r1 < 8 &&  r1 < 10
            int r1 = 5;
            Console.WriteLine("Logical and : " + (r1 < 8 && r1 < 10));

            // || 	Logical or      Returns True if one of the statements is true           r2 < 5 || r2 < 4
            int r2 = 6;
            Console.WriteLine("Logical or : " + (r2 < 5 || r2 < 4));

            // !	Logical not     Reverse the result, returns False if the result is true     !(r3 < 5 && r3 < 6)	
            int r3 = 2;
            Console.WriteLine("Logical not : " + (!(r3 < 5 && r3 < 6)));

        }
    }
}
