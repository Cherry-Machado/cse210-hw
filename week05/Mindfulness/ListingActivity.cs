using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    // Creating Attributes
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private int _count;

    //Creating Constructor.
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // Overriding Run() Method.

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        List<string> items = new List<string>();

        while (DateTime.Now < futureTime)
        {
            Console.Write("List an item: ");
            string item = Console.ReadLine();
            items.Add(item);
        }   

        _count = items.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    //Creating GetRandomPrompt Method
    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }

}