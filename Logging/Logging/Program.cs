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
            string card = string.Format("This is a test.");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Keith\logs\log.txt", true))
            {
                file.WriteLine(card);
            }
            Console.ReadLine();
        }
    }
}
