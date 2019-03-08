using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p162
{
    class Bootcamp
    {
        public Bootcamp(string name) : this(name, 110)
        {
        }
        public Bootcamp(string name, int firstCourse)
        {
            Name = name;
            Course = firstCourse;
        }
        const string courseName = "C# & .Net Framework Course";

        public string Name { get; set; }
        public int Course { get; set; }
    }
}
