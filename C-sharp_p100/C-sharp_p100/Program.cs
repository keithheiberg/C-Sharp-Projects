using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Array of sentences in The Gettysburg Address:
        string[] gba = {
        "Fourscore and seven years ago our fathers brought forth, on this continent, a new nation, conceived in liberty, and dedicated to the proposition that all men are created equal. ", 
        "Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived, and so dedicated, can long endure. ", 
        "We are met on a great battle-field of that war. ", 
        "We have come to dedicate a portion of that field, as a final resting-place for those who here gave their lives, that that nation might live. ", 
        "It is altogether fitting and proper that we should do this. ", 
        "But, in a larger sense, we cannot dedicate, we cannot consecrate--we cannot hallow--this ground. ", 
        "The brave men, living and dead, who struggled here, have consecrated it far above our poor power to add or detract.  ", 
        "The world will little note, nor long remember what we say here, but it can never forget what they did here. ", 
        "It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced. ", 
        "It is rather for us to be here dedicated to the great task remaining before us--that from these honored dead we take increased devotion to that cause for which they here gave the last full measure of devotion--that we here highly resolve that these dead shall not have died in vain--that this nation, under God, shall have a new birth of freedom, and that government of the people, by the people, for the people, shall not perish from the earth."
        };
        Console.WriteLine("Select a sentence (1-10) of The Gettysburg Address:");
        string selected = Console.ReadLine();
        int sentence = Convert.ToInt32(selected);
        if ((sentence > 0) && (sentence < 11))
        {
            Console.WriteLine("Your sentence:\n" + gba[sentence-1]);
        }
        else
        {
            Console.WriteLine("That's not part of The Gettysburg Address!");
        }
        // Array of numbers in The Fibonacci Sequence:
        int[] fibonacci = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
        Console.WriteLine("Select one of the first 13 numbers of The Fibonacci Sequence:");
        string selected2 = Console.ReadLine();
        int number = Convert.ToInt32(selected2);
        if ((number > 0) && (number < 14))
        {
            Console.WriteLine("Your number: " + fibonacci[number - 1]);
        }
        else
        {
            Console.WriteLine("That's not part of The Fibonacci Sequence!");
        }
        // List of fibers that can be used to make twine: 
        List<string> fibers = new List<string> { "wool", "cotton", "sisal", "jute", "hemp", "henequen", "coir" };
        Console.WriteLine("Select one of the fibers (1-7) that can be used to make twine:");
        string selected3 = Console.ReadLine();
        int fiber = Convert.ToInt32(selected3);
        if ((fiber > 0) && (fiber < 8))
        {
            Console.WriteLine("Your fiber: " + fibers[fiber - 1]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That's not one of the fibers!");
            Console.ReadLine();
        }
    }
}
