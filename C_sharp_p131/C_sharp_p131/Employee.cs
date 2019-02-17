using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p131
{
    public class Employee<T>
    {
        // 1. Make the Employee class take a generic type parameter.
        // 2. Add a property to the Employee class called "things" and 
        // have its data type be a generic list matching the generic type of the class.
        // 3. Instantiate an Employee object with type "string" as its generic parameter. 
        // Assign a list of strings as the property value of Things.
        // 4. Instantiate an Employee object with type "int" as its generic parameter. 
        // Assign a list of integers as the property value of Things.
        // 5. Create a loop that prints all of the Things to the Console.

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
