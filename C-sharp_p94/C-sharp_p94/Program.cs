using System;

class Program
{
    static void Main()
    {
        int n = 5;
        Console.WriteLine("Count down to zero:");
        while (n >= 0)
        {
            Console.WriteLine(n);
            n--;
        }
        string boredEntry = "";
        do
        {
            Console.WriteLine("Are you bored yet? (y/n)");
            boredEntry = Console.ReadLine();
        } while (boredEntry != "y");
        Console.WriteLine("Me, too. Let's go get a beer.");
        Console.ReadLine();
    }
}
