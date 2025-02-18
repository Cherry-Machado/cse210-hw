using System;
using System.Collections.Generic;

// CSE210 Programming with Classes.
// Cherry Machado.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine("");

        //Create a list of activities
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 11, 3), 30, 3.0),
            new Cycling(new DateTime(2024, 11, 4), 45, 12.0),
            new Swimming(new DateTime(2024, 11, 5), 60, 40)
        };

        // Iterate through the list and display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}