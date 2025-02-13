using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private readonly List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _level;
    private readonly Random _random = new Random();

    private readonly string[] _encouragingMessages = 
       {
           "🎉 You're on fire!", "🚀 To infinity and beyond!", "💪 Strength and honor!",
           "🏆 Champion status!", "🌟 Shining bright!", "🔥 Hot streak!"
       };
    
    public void start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select an option: ");

            switch (Console.ReadLine())
            {
                case "1": CreateGoal(); break;
                case "2": ListGoals(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option!"); break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            
        }

    }
    
}