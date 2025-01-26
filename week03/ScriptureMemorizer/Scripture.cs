using System;


public class Scripture
{
    private Reference reference;
    private List<Word> words;
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

    public void HideRandomWord()
    {
        Random rand = new Random();
        List<Word> visibleWords = words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Any())
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

 
    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden());
    }


}