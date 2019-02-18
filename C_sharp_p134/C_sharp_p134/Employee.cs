using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p134
{
    public class Employee<T>
    {
        // 1. Create an enum for the days of the week.
        // 2. Prompt the user to enter the current day of the week.
        // 3. Assign the value to a variable of that enum data type you just created.
        // 4. Wrap the above statement in a try/catch block and have it print 
        // "Please enter an actual day of the week." to the console if an error occurs.

        public List<T> Things { get; set; }
        //public void Quit(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
        //public int Id { get; set; }
        //public static Employee operator ==(Employee employee1, Employee employee2, bool idEqualsTrue, bool idEqualsFalse)
        //{
        //    if (employee1.Id == employee2.Id)
        //    {
        //        idEqualsTrue = true;
        //        return idEqualsTrue;
        //    }
        //    else
        //    {
        //        idEqualsFalse = false;
        //        return idEqualsFalse;
        //    }
        //}
    }
}
