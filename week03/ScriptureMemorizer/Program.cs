using System;

class Program
{
    static void Main(string[] args)
    {

var scriptures = new List<(ScriptureReference Reference, string Text)>
{
    (
        new ScriptureReference("John", 3, 16),
        "For God so loved the world that he gave his one and only Son..."
    ),

    (
        new ScriptureReference("Proverbs", 3, 5, 6),
        "Trust in the Lord with all thine heart and lean not unto thine own understanding."
    ),

    (
        new ScriptureReference("Mosiah", 2, 17),
        "When ye are in the service of your fellow beings ye are only in the service of your God."
    )
};

Random random = new Random();

var selected = scriptures[random.Next(scriptures.Count)];

var memorizer = new ScriptureMemorizer(
    selected.Reference,
    selected.Text
);

memorizer.Start();
    }
}
