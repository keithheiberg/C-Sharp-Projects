using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p162
{
    class Bootcamp
    {
        public Bootcamp(string name) : this(name, 100)
        {
        }
        public Bootcamp(string name, int firstCourse)
        {
            string Name = name;
            int Course = firstCourse;
        }
        const string courseName = "C# & .Net Framework Course";
    }
}
