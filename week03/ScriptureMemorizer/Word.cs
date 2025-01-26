using System;

public class Word
{
    private string word;
    private bool isHidden;

    public Word(string word)
    {
        this.word = word;
        this.isHidden = false;
    }

    public void Hide()
    {
        this.isHidden = true;
    }

    public void Show()
    {
        this.isHidden = false;
    }

    public string GetDisplayText()
    {
        if (isHidden)
            return new string('_', word.Length);
        else
            return word;
    }

    public bool IsHiden()
    {
        return isHidden;
    }
}