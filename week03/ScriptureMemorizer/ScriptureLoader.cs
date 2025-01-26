using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

public static class ScriptureLoader
{
    public static Dictionary<string, string> GetRandomScripture(string filePath)
    {
        var lines = File.ReadAllLines(filePath).Skip(1);
        var random = new Random();
        var selectedLine = lines.ElementAt(random.Next(lines.Count()));

        var columns = selectedLine.Split(',');

        return new Dictionary<string, string>
        {
            { "book", columns[0] },
            { "chapter", columns[1] },
            { "verse", columns[2] },
            { "endVerse", string.IsNullOrWhiteSpace(columns[3]) ? "0" : columns[3] },
            { "scriptureText", columns[4].Trim('"') }
        };
    }
}