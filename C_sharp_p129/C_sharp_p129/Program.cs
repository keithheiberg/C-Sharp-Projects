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
        // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

        {
            void Quit(Employee employee)
            {
                throw new NotImplementedException();
            }
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 1;
            employee2.Id = 2;
            if (employee1.Id == employee2.Id)
            {
                return idEqualsTrue;
            }
            else
            {
                return idEqualsFalse;
            }
        }
    }
}
