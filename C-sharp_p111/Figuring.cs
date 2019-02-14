using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

// 1. Create a class. In that class, create three methods, 
// each of which will take one integer parameter in and return an integer. 
// The methods should do some math operation on the received parameter. 
// Put this class in a separate .cs file in the application.
// 2. In the Main() program, ask the user what number they want to do the math operations on.
// 3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

namespace Calculator
{
    public class Figuring
    {
        public static int AddArg(int arg)
        {
            int number1 = arg + 2;
            return number1;
        }
        public static int SubArg(int arg)
        {
            int number2 = arg - 2;
            return number2;
        }
        public static int MultArg(int arg)
        {
            int number3 = arg * 2;
            return number3;
        }
    }
}
