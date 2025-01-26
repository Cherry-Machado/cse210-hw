using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine("");

        // This part is to Show Creativity and Exceed Requirements.
        // Instead of read the reference and scripture manually, I read them form a .csv file, this
        // way, user can go to excel or any other program like that, and fill their prefered scriptures
        // to memorize.

        // Get a random record from the CSV file

        var randomScripture = ScriptureLoader.GetRandomScripture("./data/dominio-scriptures.csv");

        // Here I create the Reference and Scripture objects with the CSV data

        Reference reference = new Reference (randomScripture["book"],
            int.Parse(randomScripture["chapter"]),
            int.Parse(randomScripture["verse"]),
            int.Parse(randomScripture["endVerse"])
        );

        Scripture scripture = new Scripture(reference, randomScripture["scriptureText"]);

        /*Reference reference = new Reference("Jhon", 3, 16);
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