using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p140
{
    class Program
    {
        static void Main(string[] args)
        // 1. In the Main() method, create a list of at least 10 employees. 
        // Each employee should have a first and last name, as well as an Id. 
        // At least two employees should have the first name "Joe".
        // 2. Using a foreach loop, create a new list of all employees with the first name "Joe".
        // 3. Do the same thing again, but this time with a lambda expression.
        // 4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

        {
            Employee owner = new Employee() { firstName = "The", lastName = "Boss", ID = 1 };
            Employee employee1 = new Employee() { firstName = "Craig", lastName = "Playstead", ID = 2 };
            Employee employee2 = new Employee() { firstName = "Joe", lastName = "Johnson", ID = 3 };
            Employee employee3 = new Employee() { firstName = "Joe", lastName = "Paulson", ID = 4 };
            Employee employee4 = new Employee() { firstName = "Joe", lastName = "Larson", ID = 5 };
            Employee employee5 = new Employee() { firstName = "Jill", lastName = "Hill", ID = 6 };
            Employee employee6 = new Employee() { firstName = "Jack", lastName = "Hill", ID = 7 };
            Employee employee7 = new Employee() { firstName = "Billy", lastName = "Jack", ID = 8 };
            Employee employee8 = new Employee() { firstName = "George", lastName = "Bush", ID = 9 };
            Employee employee9 = new Employee() { firstName = "Barack", lastName = "Obama", ID = 10 };
            Employee employee10 = new Employee() { firstName = "Donald", lastName = "Trump", ID = 11 };

            var employeeList = new List<Employee>()
            {
                owner,
                employee1,
                employee2,
                employee3,
                employee4,
                employee5,
                employee6,
                employee7,
                employee8,
                employee9,
                employee10
            };
            var employeeList2 = new List<Employee>();
            foreach (Employee employee in employeeList)
            {
                if (employee.firstName == "Joe")
                {
                    employeeList2.Add(new Employee() { firstName = employee.firstName, lastName = employee.lastName, ID = employee.ID });
                    Console.WriteLine("Foreach: Employee = " + employee.firstName + " " + employee.lastName);
                }
            }
            Console.WriteLine("\nLambda: first name == Joe:");
            var employeeList3 = new List<Employee>();
            foreach (Employee employee in employeeList.FindAll(employee => (employee.firstName == "Joe")))
            {
                employeeList3.Add(new Employee() { firstName = employee.firstName, lastName = employee.lastName, ID = employee.ID });
                Console.WriteLine("Name = " + employee.firstName + "  " + employee.lastName);
            }
            Console.WriteLine("\nLambda: ID > 5:");
            foreach (Employee employee in employeeList.FindAll(employee => (employee.ID > 5)))
            {
                employeeList3.Add(new Employee() { firstName = employee.firstName, lastName = employee.lastName, ID = employee.ID });
                Console.WriteLine("Name = " + employee.firstName + " " + employee.lastName + "; ID = " + employee.ID);
            }
            Console.ReadLine();
        }
    }
}
