using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p115
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a class. In that class, create a method that takes two integers as parameters. 
            // Make one of them optional. Have the method do a math operation and return a integer result.
            // 2. In the Main() method of the console app, instantiate the class.
            // 3. Ask the user to input two numbers, one at a time. 
            // Let them know they need not enter anything for the second number.
            // 4. Call the method in the class, passing in the one or two numbers entered.
            // 5. Try various combinations of numbers on the code, including having no second number.

            MultArg MultArg1 = new MultArg();
            int arg1 = 0;
            int arg2 = 0;
            try
            {
                Console.WriteLine("Please enter an integer:");
                string argEntry1 = Console.ReadLine();
                arg1 = Convert.ToInt32(argEntry1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("If you wish, enter a second--optional--integer:");
                string argEntry2 = Console.ReadLine();
                if (argEntry2 != "")
                {
                    arg2 = Convert.ToInt32(argEntry2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int number = arg1 * arg2;
            if (arg2 == 0)
            {
                MultArg.DoIt(arg1);
            }
            else
            {
                MultArg.DoIt(arg1, arg2);
            }
            Console.WriteLine("Thank you. Have a great day!");
            Console.ReadLine();
        }
    }
}
