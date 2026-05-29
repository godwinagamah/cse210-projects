using System;

public class Job
{
    // Member variables (Attributes)
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job()
    {
    }

    // Member function (Behavior)
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}