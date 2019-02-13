using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a list of integers. Ask the user for a number to divide each number in the list by. 
        // Write a loop that takes each integer in the list, divides it by the number the user entered, 
        // and displays the result to the screen.
        // 2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.
        // 3. Run that code, entering in zero as the number to divide by. Note any error messages you get.
        // 4. Run that code, entering in a string as the number to divide by. Note any error messages you get.
        // 5. Now put the loop in a try/catch block. Below and outside of the try/catch block, 
        // make the program display a message to the display to let you know the program has emerged 
        // from the try/catch block and continued on with program execution. 
        // In the catch block, display the error message to the screen. 
        // Then try various combinations of user input: valid numbers, zero and a string. 
        // Ensure the proper error messages display on the screen, 
        // and that the code after the try/catch block gets executed.

        List<int> uniqueList = new List<int> { 2, 4, 6, 8 };
        int result = 0;
        Console.WriteLine("Here's a list of numbers:");
        foreach (int value in uniqueList)
        {
            Console.WriteLine(value);
        }
        Console.WriteLine("Please enter a nonzero number by which to divide each number in the list:");
        // Read user's number. 
        string divisorEntry = Console.ReadLine();
        int divisor = Convert.ToInt32(divisorEntry);
        foreach (int value in uniqueList)
        {
            try
            {
                result = value / divisor;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        Console.WriteLine("Thank you. Have a great day!");
        Console.ReadLine();
    }
}
