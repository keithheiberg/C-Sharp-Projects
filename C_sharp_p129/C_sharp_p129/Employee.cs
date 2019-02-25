using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p129
{
    class Employee : Person, IQuittable
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

    {
        public int Id { get; set; }
        bool idEquals = false;
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            { 
                bool idEquals = true;
                return idEquals;
            }
            else
            {
                bool idEquals = false;
                return idEquals;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                bool idEquals = true;
                return idEquals;
            }
            else
            {
                bool idEquals = false;
                return idEquals;
            }
        }
    }
}
