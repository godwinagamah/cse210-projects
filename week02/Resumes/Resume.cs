using System;
using System.Collections.Generic; // <--- Crucial to allow lists!

public class Resume
{
    // Member variables (Attributes)
    public string _name = "";
    
    // We instantiate the list immediately so it's ready to accept elements
    public List<Job> _jobs = new List<Job>();

    // Constructor
    public Resume()
    {
    }

    // Member function (Behavior)
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Leverage the abstraction! We tell each job box to display itself.
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}