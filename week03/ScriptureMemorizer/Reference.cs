using System;

public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.verse = verse;
        this.endVerse = endVerse;
    }

    public string GetReference()
    {
        if (verse == endVerse)
            return $"{book} {verse}";
        else
            return $"{book} {verse}-{endVerse}";
    }
}