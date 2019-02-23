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
        {
            // Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            //public static bool operator ==(TwoDPoint lhs, TwoDPoint rhs)
            //{
            //    // Check for null on left side.
            //    if (Object.ReferenceEquals(lhs, null))
            //    {
            //        if (Object.ReferenceEquals(rhs, null))
            //        {
            //            // null == null = true.
            //            return true;
            //        }

            //        // Only the left side is null.
            //        return false;
            //    }
            //    // Equals handles case of null on right side.
            //    return lhs.Equals(rhs);
            //}

            //public static bool operator !=(TwoDPoint lhs, TwoDPoint rhs)
            //{
            //    return !(lhs == rhs);
            //}

            //public static bool operator ==(Box lhs, Box rhs)
            //{
            //    bool status = false;
            //    if (lhs.length == rhs.length && lhs.height == rhs.height
            //       && lhs.breadth == rhs.breadth)
            //    {

            //        status = true;
            //    }
            //    return status;
            //}
            //public static bool operator !=(Box lhs, Box rhs)
            //{
            //    bool status = false;

            //    if (lhs.length != rhs.length || lhs.height != rhs.height ||
            //       lhs.breadth != rhs.breadth)
            //    {

            //        status = true;
            //    }
            //    return status;
            //}

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            employee1.Id = 1;
            employee2.Id = 2;
            bool idEquals = false;
        }
        public static Employee operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                Console.WriteLine("The Ids are NOT equal.");
            else
                Console.WriteLine("The Ids are NOT equal.");
        }
        public static Employee operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                Console.WriteLine("The Ids are NOT equal.");
            else
                Console.WriteLine("The Ids are NOT equal.");
        }
    }
}
