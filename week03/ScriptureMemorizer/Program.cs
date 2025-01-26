using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");
        Reference reference = new Reference("Jhon", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that He gave His only Son");
        /*Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");*/

        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        while (!scripture.AllWordsHidden())
        {
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWord();
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
        }

        Console.WriteLine("All words are hidden. End Program.");
    }
}