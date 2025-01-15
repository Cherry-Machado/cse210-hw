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
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 1;
        Console.WriteLine("Tell me, What is the magic number? ");
        do 
        { 
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed the magic number!");
                Console.WriteLine($"It took you {attempts} attempts.");
                Console.Write("Do you want to play again? (y/n)");
                string playAgain = Console.ReadLine();
                if (playAgain == "y")
                {
                    magicNumber = random.Next(1, 101);
                    attempts = 1;
                    Console.WriteLine("Tell me, What is the magic number? ");
                }
                else
                {
                    Console.WriteLine("Thank you for playing!");
                }
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("Your guess is too low.");
            }
            attempts++;
        } while (magicNumber != guess);
    }
}