using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p129
{
    class Program
    {
        static void Main(string[] args)
        {
            // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 1;
            employee2.Id = 1;
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}
