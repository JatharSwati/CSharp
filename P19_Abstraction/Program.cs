using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19_Abstraction
{
    // Abstraction -
    // Data abstraction is the process of hiding certain details and showing only essential information to the user.
    // Abstraction can be achieved with either abstract classes or interfaces.
    // The abstract keyword is used for define classes and methods.

    // 1. Abstract class:
    // Abstract class is a restricted class that cannot be used to create objects
    // To access Abstract class members, it must be inherited from another class.
    // An abstract class can have both abstract and regular methods.

    // 2. Abstract method:
    // Abstract method can only be used in an abstract class.
    // It does not have a body
    // The body is provided by the derived (child) class (inherited from).
    // You must have to provid body.
    // Base class and Derived class has method with same name.
    // Use abstract keyword for base class method and override keyword for derived class method.


    class Program
    {
        static void Main(string[] args)
        {
            // Birds bird = new Birds();                        // Abstract class is a restricted class that cannot be used to create objects.

            Peacock myPeacock = new Peacock();
            myPeacock.birdsSound();
            myPeacock.color();  
        }
    }

    abstract class Birds                                        // An abstract class can have both abstract and regular methods.
    {                                                       
        public abstract void birdsSound();                      // Abstract Methods - Abstract method can only be used in an abstract class.
                                                                // Abstract method does not have a body it's body is provide by derived class.
        public void color()                                     // Regular Methods
        {
            Console.WriteLine("A color of Peacock is metallic blue and green.");
        }
    }

    class Peacock : Birds                                       // To access the abstract class, it must be inherited from another class.   
    {                                                             
        public override void birdsSound()                       // Abstract Methods body is provided by the derived class (inherited from).
        {                                                         
            Console.WriteLine("The Peacock says: meow meow");     
        }
    }

}
