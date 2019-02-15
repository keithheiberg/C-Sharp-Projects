using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p114
{
    public class MultArg
    {
        public static void DoIt(string arg)
        {
            try
            {
                int arg1 = Convert.ToInt32(arg);
                int number = arg1 * 2;
                Console.WriteLine("Your string as the interger " + arg + " doubled = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DoIt(int arg)
        {
            try
            {
                int number = arg * 3;
                Console.WriteLine("Your integer " + arg + " tripled = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DoIt(double arg)
        {
            try
            {
                double number = arg * 4.0;
                Console.WriteLine("Your double " + arg + " quadrupled = " + number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
