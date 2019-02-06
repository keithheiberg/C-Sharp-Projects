using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your age?");
        string ageEntry = Console.ReadLine();
        int age = Convert.ToInt32(ageEntry);
        Console.WriteLine("Have you ever had a DUI? (Please answer \"true\" or \"false\".)");
        string duiEntry = Console.ReadLine();
        bool flag;
        if (Boolean.TryParse(duiEntry, out flag))
            Console.WriteLine("'{0}' --> {1}", duiEntry, flag);
        else
            Console.WriteLine("Unable to parse '{0}'. Please answer \"true\" or \"false\".",
                duiEntry == null ? "<null>" : duiEntry);

        Console.WriteLine("How many speeding tickets do you have?");
        string ticketsEntry = Console.ReadLine();
        int tickets = Convert.ToInt32(ticketsEntry);
        bool qualified = (age>15) && (flag == false) && (tickets <= 3);
        Console.WriteLine("Qualified?\n" + qualified);
        Console.ReadLine();
    }
}
