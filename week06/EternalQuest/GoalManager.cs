using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
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

        public void Start()
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
                Console.Write("Select an option: ");

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

        private void DisplayPlayerInfo()
        {
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine($"Level: {_level} - {GetLevelTitle()}");
            Console.WriteLine($"Progress to next level: {_score % 1000}/1000");
        }

        private string GetLevelTitle()
        {
            string[] titles = { "Newbie", "Apprentice", "Warrior", "Hero", "Legend", "Eternal Champion" };
            return _level < titles.Length ? titles[_level] : "Cosmic Overlord";
        }

        private void CreateGoal()
        {
            Console.Write("\nGoal types:\n1. Simple\n2. Eternal\n3. Checklist\nChoose type: ");
            var type = Console.ReadLine();

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Description: ");
            var desc = Console.ReadLine();
            Console.Write("Points: ");
            int.TryParse(Console.ReadLine(), out int points);

            switch (type)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, desc, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;
                case "3":
                    Console.Write("Target completions: ");
                    int.TryParse(Console.ReadLine(), out int target);
                    Console.Write("Bonus points: ");
                    int.TryParse(Console.ReadLine(), out int bonus);
                    _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type!");
                    break;
            }
        }

        private void ListGoals()
        {
            Console.WriteLine("\nCurrent Goals:");
            for (int i = 0; i < _goals.Count; i++)
                Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

        private void RecordEvent()
        {
            ListGoals();
            Console.Write("Select goal to record: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
            {
                int points = _goals[index - 1].RecordEvent();
                _score += points;
                Console.WriteLine($"\n{_encouragingMessages[_random.Next(_encouragingMessages.Length)]}");
                Console.WriteLine($"Earned {points} points!");

                if (points >= 500) DisplayFireworks();
                CheckLevelUp();
            }
            else Console.WriteLine("Invalid selection!");
        }

        private void CheckLevelUp()
        {
            int newLevel = _score / 1000;
            if (newLevel <= _level) return;
            
            Console.WriteLine("\n🌟 LEVEL UP! 🌟");
            Console.WriteLine($"You've reached level {newLevel}!");
            Console.WriteLine(GetLevelUpMessage(newLevel));
            _level = newLevel;
        }

        private string GetLevelUpMessage(int level) => level switch
        {
            1 => "You're getting started!",
            2 => "Building momentum!",
            3 => "Halfway to greatness!",
            4 => "Unstoppable!",
            _ => "Legendary status achieved!"
        };

        private static void DisplayFireworks()
        {
            Console.WriteLine(@"
               \|/        \|/
            .  @@@@  .   @@@@
            /`\\''//`\  //''//`\
           @@|o|  |o|@@@|o|  |o|@@
            \/'\  /`\/  /'\  /`\/
               \  /      \  /
                \/        \/
            ");
        }

        private void SaveGoals()
        {
            Console.Write("Filename: ");
            using var writer = new StreamWriter(Console.ReadLine());
            writer.WriteLine(_score);
            _goals.ForEach(g => writer.WriteLine(g.GetStringRepresentation()));
        }

        private void LoadGoals()
        {
            Console.Write("Filename: ");
            string filename = Console.ReadLine();
            if (!File.Exists(filename)) return;
            
            var lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _level = _score / 1000;
            
            _goals.Clear();
            foreach (var line in lines[1..])
            {
                var parts = line.Split('|');
                switch (parts[0])
                {
                    case "SimpleGoal":
                        var sg = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                        if (bool.Parse(parts[4])) sg.RecordEvent();
                        _goals.Add(sg);
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "ChecklistGoal":
                        var cg = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), 
                            int.Parse(parts[5]), int.Parse(parts[4]));
                        for (int i = 0; i < int.Parse(parts[6]); i++) cg.RecordEvent();
                        _goals.Add(cg);
                        break;
                }
            }
        }
    }
}