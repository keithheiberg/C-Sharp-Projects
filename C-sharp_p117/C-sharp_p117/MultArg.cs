using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p117
{
    public class MultArg
    {
        public static void DoIt(int arg1)
        // 1. Create a class. In that class, create a void method that outputs an integer. 
        // Have the method divide the data passed to it by 2.
        // 2. In the Main() method, instantiate that class.
        // 3. Have the user enter a number. Call the method on that number. 
        // Display the output to the screen. It should be the entered number, divided by two.
        // 4. Create a method with output parameters.
        // 5. Overload a method.
        // 6. Declare a class to be static.

        {
            try
            {
                int number = arg1 / 2;
                Console.WriteLine("The integer " + arg1 + " / 2 = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DoIt(int arg1, out int number, int arg2 = 2)
        {
            number = 0;
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

            try
            {
                number = arg1 * arg2;
                Console.WriteLine("The integer " + arg1 + " * the integer " + arg2 + " = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
