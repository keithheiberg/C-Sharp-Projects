using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional Array of strings. Ask the user to input some text. 
        // Create a loop that goes through each string in the Array, adding the user’s text to the string. 
        // Then create a loop that prints off each string in the Array on a separate line.
        string[] previousLife = {
        "I lived in: ",
        "My occupation was: ",
        "I died due to: ",
        "Other people I recognize from that life include: "
        };
        int i = 0;
        string current = "";
        string entry = "";
        string combined = "";
        Console.WriteLine("Enter four details from your most recent lifetime:");
        while (i < 4)
        {
            current = previousLife[i];
            Console.WriteLine(current);
            entry = Console.ReadLine();
            combined = current + entry;
            previousLife[i] = combined;
            // Console.WriteLine(previousLife[i]);
            i++;
        }

        // Create an infinite loop.
        //int j = 0;
        //do
        //{
        //    Console.WriteLine(previousLife[j]);
        //    j++;
        //} while (j >= 0);

        // Fix the infinite loop so it will execute.
        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
        int j = 0;
        while (j < 4)
        {
            Console.WriteLine(previousLife[j]);
            j++;
        } 
        // Console.ReadLine();

        // Create a loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
        int k = 0;
        while (k <= 3)
        {
            Console.WriteLine(previousLife[k]);
            k++;
        }
        // Console.ReadLine();

        // Create a List of strings where each item in the list is unique. 
        // Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays 
        // the index of the array that contains matching text on the screen.
        List<string> uniqueList = new List<string> { "Tinker", "Tailor", "Soldier", "Spy" };
        Console.WriteLine("Please type name of desired occupation in your next life:");
        foreach (string value in uniqueList)
        {
            Console.WriteLine(value);
        }
        string occupation = Console.ReadLine();

        // Add code to that above loop that tells a user if they put in text that isn’t in the List.
        // Add code to that above loop that stops it from executing once a match has been found.
        int l = 0;
        string response = "";
        while (l <= 3)
        {
            if (occupation == uniqueList[l])
            {
                response = "You will achieve your dream!";
            }
            else
            {
                response = "That occupation doesn't match your karma.";
            }
            l++;
        }
        Console.WriteLine(response);
        // Console.ReadLine();

        // Create a List of strings that has at least two identical strings in the List. 
        // Ask the user to select text to search for in the List. 
        // Create a loop that iterates through the list and then displays the indices of the array 
        // that contain matching text on the screen.
        // Add code to that above loop that tells a user if they put in text that isn’t in the List.
        List<string> bandList = new List<string> { "Sha", "Na", "Na" };
        int m = 0;
        Console.WriteLine("Please type a syllable to search for in the band's name:");
        foreach (string syllable in bandList)
        {
            Console.WriteLine(syllable);
        }
        string choice = Console.ReadLine();
        string snappyComeback = "";
        while (m <= 2)
        {
            if (choice == bandList[m])
            {
                snappyComeback = "You're one hep cat, daddy-o! Index = " + m;
            }
            else
            {
                snappyComeback = "Have you considered a career in computer programming?";
            }
            m++;
        }
        Console.WriteLine(snappyComeback);
        // Console.ReadLine();

        // Create a List of strings that has at least two identical strings in the List. 
        // Create a foreach loop that evaluates each item in the list, 
        // and displays a message showing the string and whether or not it has already appeared in the list.

        string newSyllable = "";
        foreach (string syllable in bandList)
        {
            if (newSyllable != syllable)
            {
                Console.WriteLine(syllable + " is, like, totally hip!");
                newSyllable = syllable;
            }
            else
            {
                Console.WriteLine(syllable + " has been done.");
            }
        }
        Console.ReadLine();
    }
}
