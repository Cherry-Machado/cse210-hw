using System;

public class Scripture
{
    private Reference reference;
    private List<WaitForChangedResult> words;
    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        words = new List<Word>();

        foreach (var word in scriptureText.Split(' '))
        {
            words.Add(new Word(word));
        }
    }

    public string GetScripture()
    {
        return $"{reference.GetReference()}: {string.Join(" ", words.Select(w => w.GetDisplayText()))}";
    }


}