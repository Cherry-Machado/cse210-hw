using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Hello World! This is the Fractions Project.");

       // Default fraction
        Fraction f1 = new Fraction();
        Console.WriteLine("Initial Fraction:");
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Fraction with one parameter
        Console.WriteLine("Fraction with one parameter:");
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Fraction with two parameters
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine("Fraction with two parameters:");
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Using setters to change and display the fraction
        Console.WriteLine("Updating Fraction (f3) Using Getters and setters:");
        f3.SetTop(1);
        f3.SetBottom(3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

    }
}