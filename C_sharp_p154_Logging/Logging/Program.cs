using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string numberEntry = Console.ReadLine();
            string userEntry = string.Format("Your number is: " + numberEntry);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Keith\logs\log.txt", true))
            {
                file.WriteLine(userEntry);
            }
            string readText = File.ReadAllText(@"C:\Users\Keith\logs\log.txt");
            Console.WriteLine(readText);
            Console.ReadLine();
        }
    }
}
