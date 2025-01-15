using System;

class Program
{
    static void Main(string[] args)
    {
        //Author: CherryMachado
        //Purpose: Guess My Number game Program.
        //Restrictions: None
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("Welcome to the Guess My Number game!");
        int magicNumber = 0;
        int guess = 0;
        do 
        { 
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Your guess is too low.");
            }
        } while (magicNumber != guess);
    }
}