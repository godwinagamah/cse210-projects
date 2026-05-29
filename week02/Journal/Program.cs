/*
  EXCEEDING REQUIREMENTS STATEMENT:
  I exceeded the basic requirements by adding an emotional tracking component to the journal.
  When writing an entry, the user is prompted to rate their current mood on a scale of 1-5. 
  This mood data is dynamically bound to the Entry object, appended cleanly to our file architecture, 
  and displayed seamlessly alongside historical entries.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();
                
                // --- MOOD TRACKING INJECTION ---
                Console.Write("How would you rate your mood today from 1-5? ");
                string currentMood = Console.ReadLine();
                
                Entry newEntry = new Entry();
                newEntry._promptText = prompt;
                newEntry._entryText = response;
                newEntry._mood = currentMood; // <-- Save mood text
                newEntry._date = DateTime.Now.ToShortDateString();

                myJournal.AddEntry(newEntry);
            }
        }        // ... (Rest of choices 2, 3, 4, and 5 stay exactly the same as before)
    }
}        