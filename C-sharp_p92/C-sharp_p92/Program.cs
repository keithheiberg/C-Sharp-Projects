using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPackage weight?");
        string weightEntry = Console.ReadLine();
        double weight = Convert.ToDouble(weightEntry);
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Package width?");
            string widthEntry = Console.ReadLine();
            double width = Convert.ToDouble(widthEntry);
            Console.WriteLine("Package height?");
            string heightEntry = Console.ReadLine();
            double height = Convert.ToDouble(heightEntry);
            Console.WriteLine("Package length?");
            string lengthEntry = Console.ReadLine();
            double length = Convert.ToDouble(lengthEntry);
            double dimensions = height + width + length;
            if (dimensions > 50.0)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                double cost = (dimensions * weight) / 100.0;
                Console.WriteLine("Your estimated total for shipping this package is: " + cost.ToString("C") + "\nThank you.");
                Console.ReadLine();
            }
        }
    }
}
