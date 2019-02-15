using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p113
{
    public class MultArg
    {
        public static void DoIt()
        {
            try
            {
                Console.WriteLine("Please enter an integer:");
                string argEntry1 = Console.ReadLine();
                int arg1 = Convert.ToInt32(argEntry1);
                Console.WriteLine("Enter another integer:");
                string argEntry2 = Console.ReadLine();
                int arg2 = Convert.ToInt32(argEntry2);
                int number = arg1 * arg2;
                Console.WriteLine("Your result: " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
