using System;

namespace my_first_hello_world
{
    class Program {

        static void Main(string [] args) {

            Console.WriteLine("Welcome to my 'Hello World' console!");
    
            
            Console.WriteLine();

           /* int myNum = 15;
            Console.WriteLine("\t{0} {1}\n" myNum); 
            
            Console.WriteLine($"This is string interpolation! The number is {myNum}"); */

            Console.WriteLine("Tell me your name.");/* Asking the user for their first name */
            Console.Write("Type your first name: ");/* prompt the user to enter their first name */
            
            /* Gets the user input of their name*/
            string myFirstName; 
            myFirstName = Console.ReadLine();
            
            /* This adds a space between each questions */
            Console.WriteLine();

            Console.WriteLine("How old are you? ");/* Asking the user how old they are */
            
            /* Gets the user input of their age*/
            Console.Write("Type your age: ");
            string myAge = Console.ReadLine();/* prompt the user to enter their age */

            Console.WriteLine();/* Adds a space between the prompt questions/ responses and the display at the bottom */
            Console.WriteLine($"Hello, {myFirstName} you are {myAge} years old.");
        }
    }
}
