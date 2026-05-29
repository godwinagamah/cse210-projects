using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Create and populate instance #1 of Job
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // 2. Create and populate instance #2 of Job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // 3. Create the main Resume container object
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        // 4. Add our custom Job objects directly into the Resume list box
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // 5. Fire off the display loop hierarchy
        myResume.Display();
    }
}