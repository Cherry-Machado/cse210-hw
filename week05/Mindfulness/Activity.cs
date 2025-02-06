using System;
using System.Collections.Generic;
using System.Threading;

abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
}

public void DisplayStartingMessage()
{
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine(_description");
    Console.WriteLine("Enter the duration of the activity in seconds: ");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Prepare to begin...");
    ShowSpinner(3);
}

public void DisplayEndingMessage()
{
    Console.WriteLine("Good job!");
    Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
    ShowSpinner(3);
}

