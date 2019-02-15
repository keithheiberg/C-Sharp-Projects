using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p115
{
    public class MultArg
    {
        public static void DoIt(int arg1, int arg2 = 2)
        {
            try
            {
                int number = arg1 * arg2;
                Console.WriteLine("The integer " + arg1 + " * the integer " + arg2 + " = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
