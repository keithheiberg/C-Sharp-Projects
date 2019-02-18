using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p134
{
    class Program
    {
        static void Main(string[] args)
        // 1. Create an enum for the days of the week.
        // 2. Prompt the user to enter the current day of the week.
        // 3. Assign the value to a variable of that enum data type you just created.
        // 4. Wrap the above statement in a try/catch block and have it print 
        // "Please enter an actual day of the week." to the console if an error occurs.
        {
            string dayEntry = "";
            try
            {
                DateTime dateValue = new DateTime();
                Console.WriteLine("Please enter the current day of the week:");
                dayEntry = Console.ReadLine();
                if (dayEntry == dateValue.ToString("dddd"))
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("{0} = {1:D}", dayEntry, Enum.Parse(typeof(DaysOfTheWeek), dayEntry));
                }
                else
                {
                    Console.WriteLine("Sorry, that's not correct.");
                }
            }
            catch (Exception ex)
                {
                    Console.WriteLine(ex + "please enter an actual day of the week.");
                }
            Console.ReadLine();
        }
        public DayOfWeek DayOfWeek { get; }
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
