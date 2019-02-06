using System;
using System.Text;

class Program
{
    static void Main()
    {
        string firstString = "The ";
        string secondString = "Gettysburg ";
        string thirdString = "Address";
        string title = firstString + secondString + thirdString;
        string uppercaseTitle = title.ToUpper();
        StringBuilder gba = new StringBuilder(uppercaseTitle + "\n", 1500);
        gba.Append("Fourscore and seven years ago our fathers brought forth, on this continent, a new nation, conceived in liberty, and dedicated to the proposition that all men are created equal. ");
        gba.Append("Now we are engaged in a great civil war, testing whether that nation, or any nation so conceived, and so dedicated, can long endure. ");
        gba.Append("We are met on a great battle-field of that war. ");
        gba.Append("We have come to dedicate a portion of that field, as a final resting-place for those who here gave their lives, that that nation might live. ");
        gba.Append("It is altogether fitting and proper that we should do this. ");
        gba.Append("But, in a larger sense, we cannot dedicate, we cannot consecrate--we cannot hallow--this ground. ");
        gba.Append("The brave men, living and dead, who struggled here, have consecrated it far above our poor power to add or detract.  ");
        gba.Append("The world will little note, nor long remember what we say here, but it can never forget what they did here. ");
        gba.Append("It is for us the living, rather, to be dedicated here to the unfinished work which they who fought here have thus far so nobly advanced. ");
        gba.Append("It is rather for us to be here dedicated to the great task remaining before us--that from these honored dead we take increased devotion to that cause for which they here gave the last full measure of devotion--that we here highly resolve that these dead shall not have died in vain--that this nation, under God, shall have a new birth of freedom, and that government of the people, by the people, for the people, shall not perish from the earth.");
        Console.WriteLine(gba);
        Console.ReadLine();
    }
}
