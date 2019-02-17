using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p129
{
    class Person
    {
        // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

        public string firstName { get; set; }
        public string lastName { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}
