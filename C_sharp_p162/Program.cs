using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p162
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBootcamp = new Bootcamp("Software Developer", 100);
            var newBootcamp2 = new Bootcamp("Software Developer");

            Console.WriteLine(newBootcamp.Name + " " + newBootcamp.Course);
            Console.WriteLine(newBootcamp2.Name + " " + newBootcamp2.Course);
            Console.ReadLine();
        }
    }
}
