using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17_PropertiesAndEncapsulation
{
    // Encapsulation:
    // The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.
    // To achieve this, you must: 
    // declare fields/variables as private
    // provide public get and set methods, through properties, to access and update the value of a private field


    // Properties:
    // A property is like a combination of a variable and a method, and it has two methods: a get and a set method:

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Swati";
            employee.LastName = "Jathar";
            // employee.FullName = "Swati Jathar";           // FullName has only get method, so it is read-only Property. You can not set value to FullName.
            employee.Age = 22;
            // employee.salary = 30000.40;                   // You can not access the private variable salary in other class.
            employee.Salary = 30000.45;                      // To get or set value to private variable salary, use Salary Property.


            Console.WriteLine($"My first name is {employee.FirstName} and last name is {employee.LastName}.");
            Console.WriteLine($"My full name is {employee.FullName}.");                                          // FullName has only get method, so it is read-only Property. So you can only access its value.
            // Console.WriteLine($"My age is {employee.Age}.");                                                  // Age has only set method, so it is write-only Property. You can not get value to Age.
            // Console.WriteLine($"My salary is {employee.salary}.");                                            // You can not access the private variable salary in other class.                   
            Console.WriteLine($"My salary is {employee.Salary}.");                                               // To get or set value to private variable salary, use Salary Property.
        }
    }


    class Employee
    {
        private double salary;              // For Encapsulation - declare fields/variables as private     

        public double Salary                // For Encapsulation - provide public get and set methods, through properties, to access and update the value of a private field.
        {
            get { return salary; }

            set { salary = value; }
        }


        public string FirstName { get; set; }                                           // Normal properties

        public string LastName { get; set; }                                            // Normal properties

        public string FullName
        {                                                        // read-only (if you only use the get method)
            get
            {
                string fullname = $"{FirstName} {LastName}";
                return fullname;
            }
        }

        public int Age { set { } }                               // write-only (if you only use the set method)
    }


    // Why Encapsulation?
    // Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    // Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
    // Flexible: the programmer can change one part of the code without affecting other parts
    // Increased security of data
}
