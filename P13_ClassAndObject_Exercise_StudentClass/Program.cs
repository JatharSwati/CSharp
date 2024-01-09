using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ClassAndObject_Exercise_StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student swati = new Student();
            swati.firstName = "Swati";
            swati.lastName = "Jathar";
            swati.birthYear = 2001;
            swati.rollNo = 25;
            swati.city = "Sangmner";
            swati.weight = 49.5;

            swati.GetStudentInfo();

            Student pradip = new Student();
            pradip.firstName = "Pradip";
            pradip.lastName = "Jathar";
            pradip.birthYear = 1999;
            pradip.rollNo = 30;
            pradip.city = "Pune";
            pradip.weight = 55.9;

            pradip.GetStudentInfo();

            Student pravin = new Student();
            pravin.firstName = "Pravin";
            pravin.lastName = "Gunjal";
            pravin.birthYear = 1997;
            pravin.rollNo = 35;
            pravin.city = "Mumbai";
            pravin.weight = 54.5;

            pravin.GetStudentInfo();

            Student shubhangi = new Student();
            shubhangi.firstName = "Shubhangi";
            shubhangi.lastName = "Gunjal";
            shubhangi.birthYear = 1999;
            shubhangi.rollNo = 40;
            shubhangi.city = "Mumbai";
            shubhangi.weight = 45.7;

            shubhangi.GetStudentInfo();
        }
    }


    class Student
    {
        // Fields

        public string firstName;                // variable

        public string lastName;                 // variable

        public int birthYear;                   // variable

        public int rollNo;                      // variable

        public string city;                     // variable

        public double weight;                   // variable


        // Methods
        public void GetStudentInfo()            // Method
        {
            string fullName = firstName + " " + lastName;

            Console.WriteLine($"My name is {fullName}. My age is {StudentAge()} and my weight is {weight}. I am from {city}. My roll number is {rollNo}.");

            Console.WriteLine();
        }


        // Function
        public int StudentAge()                 // Method
        {
            int age = 2024 - birthYear;

            return age;
        }
    }
}
