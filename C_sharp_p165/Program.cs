using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p165
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime presentMoment = DateTime.Now;
            int ageInt = 0;
            int birthYear = 0;
            Console.WriteLine("Present year: " + presentMoment.Year);
            Console.WriteLine("Please enter your age as an integer:");
            try
            {
                string ageEntry = Console.ReadLine();
                ageInt = Convert.ToInt32(ageEntry);

            }
            catch (System.ArgumentNullException)
            {
                System.Console.WriteLine("String is null.");
            }
            catch (System.FormatException)
            {
                System.Console.WriteLine("String does not consist of an " +
                                "optional sign followed by a series of digits.");
            }
            catch (System.OverflowException)
            {
                System.Console.WriteLine("Overflow in string to int conversion.");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred in your age entry. Please see your System Administrator.");
                Console.ReadLine();
            }
            if (ageInt < 1)
            {
                Console.WriteLine("Please enter a positive integer greater than zero.");
                Console.ReadLine();
            }
            Console.WriteLine("You entered your age as: " + ageInt);
            try
            {
                DateTime yearBorn = DateTime.Now.AddYears(-ageInt);
                birthYear = yearBorn.Year;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred in your year of birth calculation.");
            }
            Console.WriteLine("You were born in the year: " + birthYear);
            Console.ReadLine();
        }
    }
}
