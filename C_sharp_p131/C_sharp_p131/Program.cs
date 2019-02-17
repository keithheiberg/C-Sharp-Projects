using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p131
{
    class Program
    {
        static void Main(string[] args)
        // 1. Make the Employee class take a generic type parameter.
        // 2. Add a property to the Employee class called "things" and 
        // have its data type be a generic list matching the generic type of the class.
        // 3. Instantiate an Employee object with type "string" as its generic parameter. 
        // Assign a list of strings as the property value of Things.
        // 4. Instantiate an Employee object with type "int" as its generic parameter. 
        // Assign a list of integers as the property value of Things.
        // 5. Create a loop that prints all of the Things to the Console.

        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "one", "two", "three" };
            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 1, 2, 3 };

            foreach (String thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (Int32 thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

            //void Quit(Employee employee)
            //{
            //    throw new NotImplementedException();
            //}
            //Employee employee1 = new Employee();
            //Employee employee2 = new Employee();
            //employee1.Id = 1;
            //employee2.Id = 2;
            //if (employee1.Id == employee2.Id)
            //{
            //    return idEqualsTrue;
            //}
            //else
            //{
            //    return idEqualsFalse;
            //}
        }
    }
}
