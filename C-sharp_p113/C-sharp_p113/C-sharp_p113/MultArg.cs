using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p113
{
    public class MultArg
    {
        public static void DoIt(int firstArg, int secondArg)
        {
            try
            {
                int number = firstArg * secondArg;
                Console.WriteLine("Your result: " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
