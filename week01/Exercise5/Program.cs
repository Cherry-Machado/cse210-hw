using System;

class Program
{
    static void Main(string[] args)
    {
        //Author: CherryMachado
        //Purpose: Working with Functions in C#.
        // This is a diferent way to write the code from Exercise5 week1, than the example one.
        // I just wanted to be creative and try to write the code in a different way.
        
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("");
        DisplayWelcome();
        DisplayResult("userName", 0);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName(string userName)
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
            Console.WriteLine($"{PromptUserName("userName")}, the square of your favorite number is: {Math.Pow(PromptUserNumber(0), 2)}");
        }
        
       /*
       // This is the sample code from Exercise5 given by the teacher.
       {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
        }

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    } */

    }
}