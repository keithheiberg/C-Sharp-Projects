using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p140
{
    class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}

