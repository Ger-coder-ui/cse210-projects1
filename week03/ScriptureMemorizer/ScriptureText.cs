using System;
using System.Collections.Generic;

public class Scripture
{
    public ScriptureReference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWords(int count)
    {
        var random = new Random();
        var hiddenCount = 0;
        var visibleWords = Words.FindAll(w => !w.IsHidden());

        if (visibleWords.Count == 0)
            return false;
        while (hiddenCount < count && visibleWords.Count > 0)
        {
            var index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords = Words.FindAll(w => !w.IsHidden());
            hiddenCount++;
        }

        return true;

    }

    public bool IsFullyHidden()
    {
        return Words.All(w => w.IsHidden());
    }
}
