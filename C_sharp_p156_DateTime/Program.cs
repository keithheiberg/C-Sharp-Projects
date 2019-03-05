using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime;

namespace DateTimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursInt = 0;
            DateTime presentMoment = DateTime.Now;
            Console.WriteLine("It is presently " + presentMoment);
            try
            {
                Console.WriteLine("Please enter a number of hours.");
                string hoursEntry = Console.ReadLine();
                hoursInt = Convert.ToInt32(hoursEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            DateTime yourDateTime = new DateTime(hoursInt);
            Console.WriteLine("Present {0} + your entry {1} hour(s) = {2}", presentMoment, yourDateTime,
                presentMoment.AddHours(hoursInt));
            Console.ReadLine();
        }
    }
}
