using System;

class Program
{
    static void Main(string[] args)
    {
        //Author: CherryMachado
        //Purpose: Working with Functions in C#.
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string DisplayPersonalMessage(string userName)
        {
            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber(int number)
        {
            Console.Write("Please enter your favorite number: ");
            number = int.Parse(Console.ReadLine());
            return number;
        }
        
        static void DisplayResult(string userName, int number)
        {
            Console.WriteLine($"{DisplayPersonalMessage("userName")}, the square of your favorite number is: {Math.Pow(PromptUserNumber(0), 2)}");
        }

        DisplayWelcome();
        DisplayResult("userName", 0);
        
    }
}