using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p137
{
    class Program
    // 1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
    // 2. In the Main() method, create an object of data type Number and assign an amount to it.
    // 3. Print this amount to the console.
    {
        static void Main(string[] args)
        {
            Number number1 = new Number();
            number1.Amount = 3.14M;
            Console.WriteLine("The struct Number 'Amount' is: " + number1.Amount);
            Console.ReadLine();
        }

        public struct Number
        {
            public decimal Amount;

        }
    }
}
