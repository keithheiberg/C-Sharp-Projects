using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p117
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a class. In that class, create a void method that outputs an integer. 
            // Have the method divide the data passed to it by 2.
            // 2. In the Main() method, instantiate that class.
            // 3. Have the user enter a number. Call the method on that number. 
            // Display the output to the screen. It should be the entered number, divided by two.
            // 4. Create a method with output parameters.
            // 5. Overload a method.
            // 6. Declare a class to be static.

            //Online research: out parameter modifier(C# Reference)
            //•	03 / 05 / 2018
            //The out keyword causes arguments to be passed by reference. 
            // It is like the ref keyword, except that ref requires that 
            // the variable be initialized before it is passed.It is also like the in keyword, 
            // except that in does not allow the called method to modify the argument value.
            // To use an out parameter, both the method definition and the calling method 
            // must explicitly use the out keyword.For example:
            //C#CopyRun
            //int initializeInMethod;
            //OutArgExample(out initializeInMethod);
            //Console.WriteLine(initializeInMethod);     // value is now 44
            //void OutArgExample(out int number)
            //{
            //    number = 44;
            //}


            MultArg MultArg1 = new MultArg();
            int arg1 = 0;
            int arg2 = 0;
            int number1;
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
            number1 = arg1 / 2;
            if (arg2 == 0)
            {
                MultArg.DoIt(arg1, out int number);
                Console.WriteLine(number);

            }
            else
            {
                MultArg.DoIt(arg1, out int number);
                Console.WriteLine(number);
            }

            Console.WriteLine("Thank you. Have a great day!");
            Console.ReadLine();
        }
    }
}
