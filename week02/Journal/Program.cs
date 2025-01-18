using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("Welcome to the Journal Program!");
        // This program will help you to start a Joournal by asking you a series of questions and save your answers to a file.
        Console.WriteLine("");
        
        Console.WriteLine("1. Write in Journal");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Load file to Journal");
        Console.WriteLine("4. Save to file");
        Console.WriteLine("5. Quit");
        int menu;
        do
        {
            Console.Write("Please select an option: ");
            menu = Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Display();
                    break;
                case 2:
                    Console.WriteLine("Display");
                    break;
                case 3:
                    Console.WriteLine("Load");
                    break;
                case 4:
                    Console.WriteLine("Save");
                    break;
                case 5:
                    Console.WriteLine("Quit");
                    break;
                default:
                    Console.WriteLine($"Your option is incorrect. Please try again.");
                    break;
                static void Display()
                {
                    Console.WriteLine("Display Journal");
                }
            }
        } while (menu != 5);
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        PromptGenerator thePromptGenerator = new PromptGenerator();
    }
}