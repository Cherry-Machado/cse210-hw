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


        }
    }
}