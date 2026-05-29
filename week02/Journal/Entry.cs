using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood; // <-- New variable

    public void Display()
    {
        Console.WriteLine($"Date: {_date} — Prompt: {_promptText}");
        Console.WriteLine($"Mood: {_mood}/5"); // <-- New display line
        Console.WriteLine($"{_entryText}\n");
    }
}