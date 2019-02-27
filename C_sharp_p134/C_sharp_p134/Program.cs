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
        {
            string dayEntry = "";
            DateTime dateValue = DateTime.Now;
            string today = dateValue.ToString("dddd");
            Console.WriteLine("Please enter the current day of the week:");
            try
            {
                dayEntry = Console.ReadLine();
                int dayNumber = Int32.Parse(dayEntry);
                int x = (int)Enum.Parse(typeof(DaysOfTheWeek), dayEntry);
                Console.WriteLine("Day number entered = " + x);
                int y = (int)Enum.Parse(typeof(DaysOfTheWeek), today);
                Console.WriteLine("Today's number = " + y);
                Console.WriteLine("You entered: " + dayEntry);
                Console.WriteLine("Today is: " + today);
                Enum.Parse(typeof(DaysOfTheWeek), dayEntry);
                if (dayEntry == today)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine(dayEntry + "is not the current day of the week. Please try again.");
                }
            }
            catch 
            {
                Console.WriteLine(dayEntry + "is not the current day of the week. Please try again.");
            }
            Console.ReadLine();
        }
        public static DateTime Now { get; }
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
