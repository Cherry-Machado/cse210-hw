using System;

// Defines the structure of a journal entry.
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void DisplayAll()
    {
       Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
       Console.WriteLine($"Entry: {_entryText}");
        
    }
}