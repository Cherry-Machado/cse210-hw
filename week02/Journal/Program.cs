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

        Journal myJournal = new Journal();
        PromptGenerator myPromptGenerator = new PromptGenerator();

        int menu;
        do
        {
            Console.WriteLine("1. Write in Journal");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load file to Journal");
            Console.WriteLine("4. Save to file");
            Console.WriteLine("5. Quit");
            Console.Write("Please select an option: ");
            menu = Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    string prompt;
                    do
                    {
                        prompt = myPromptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {prompt}");
                        prompt = myPromptGenerator.GetRandomPrompt();
                        Console.Write("Your answer: ");
                        string userEntry = Console.ReadLine();

                        Entry newEntry = new Entry()
                        {
                            _date = DateTime.Now.ToString("MM/dd/yyyy"),
                            _promptText = prompt,
                            _entryText = userEntry
                        };
                        myJournal.AddEntry(newEntry);
                        Console.Write("Press '1' to add another entry or any other to exit. ");
                    } while (Console.ReadLine() == "1");
                    break;
                case 2:
                    myJournal.DisplayAll();
                    break;
                case 3:
                    Console.WriteLine("What's the file name? ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    break;
                case 4:
                    Console.WriteLine("What's the file name? ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    break;
                case 5:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Your option is incorrect. Please try again.");
                    break;
            }
        } while (menu != 5);
        
    }
}