using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Create a class. In that class, create three methods, 
            // each of which will take one integer parameter in and return an integer. 
            // The methods should do some math operation on the received parameter. 
            // Put this class in a separate .cs file in the application.
            // 2. In the Main() program, ask the user what number they want to do the math operations on.
            // 3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

            Console.WriteLine("Please enter an integer:");
            try
            {
                string argEntry = Console.ReadLine();
                int arg = Convert.ToInt32(argEntry);
                int number1 = Figuring.AddArg(arg);
                int number2 = Figuring.SubArg(arg);
                int number3 = Figuring.MultArg(arg);
                Console.WriteLine("Your number plus two = " + number1);
                Console.WriteLine("Your number minus two = " + number2);
                Console.WriteLine("Your number times two = " + number3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Thank you. Have a great day!");
            Console.ReadLine();

        }
    }
}

