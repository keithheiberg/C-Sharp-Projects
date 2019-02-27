using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p140
{
    class Person
    {
        // 

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }
        public virtual void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
    }
}

