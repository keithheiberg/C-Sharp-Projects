using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p129
{
    class Employee : Person, IQuittable
    {
        // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
        public int Id { get; set; }
        public static Employee operator== (Employee employee1, Employee employee2, bool idEqualsTrue, bool idEqualsFalse)
        {
            if (employee1.Id == employee2.Id)
            {
                idEqualsTrue = true;
                return idEqualsTrue;
            }
            else
            {
                idEqualsFalse = false;
                return idEqualsFalse;
            }
        }
    }
}
