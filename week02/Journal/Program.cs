using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    public static void DisplayMenu(string[] menuOptions)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("This program allows you to write, view, save, and load journal entries. \n");
        for (int i = 0; i < menuOptions.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuOptions[i]}");
        }
    }
    
    static void Main(string[] args)
    {
        Console.Title = "Journal Program";
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("");

        Journal myJournal = new Journal();
        PromptGenerator myPromptGenerator = new PromptGenerator();

        string[] menuOptions = {
            "Write in Journal",
            "Display Journal",
            "Load file to Journal",
            "Save to file",
            "Quit"
        };

        int menu;
        do
        {
            DisplayMenu(menuOptions);
            Console.Write("Please select an option (1-5): ");
            if (!int.TryParse(Console.ReadLine(), out menu) || menu < 1 || menu > 5)
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 5. ");
                Console.Write("Press any key to return to the menu...");
                Console.ReadKey();
                continue;
            }
           
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
                    Console.Write("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("What's the file name? ");
                    string loadFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadFileName);
                    Console.Write("Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("What's the file name? ");
                    string saveFileName = Console.ReadLine();
                    myJournal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved successfully! Press any key to return to the menu...");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                /*default:
                    Console.WriteLine("Your option is incorrect. Please try again.");
                    break;*/
            }
        } while (menu != 5);
        
    }
}