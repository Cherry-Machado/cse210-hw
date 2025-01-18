using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

public  class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            while (!reader.EndOfStream)
            {
                Entry entry = new Entry();
                entry._date = reader.ReadLine();
                entry._promptText = reader.ReadLine();
                entry._entryText = reader.ReadLine();
                _entries.Add(entry);
            }
        }
    }
}