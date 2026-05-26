using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        double grade = Convert.ToDouble(Console.ReadLine());
        string letter = "";

        
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        Console.WriteLine($"Your letter grade is: {letter}");

        Console.WriteLine(new string('-', 30)); 

        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course! Keep up the great work.");
        }
        else
        {
            Console.WriteLine("Don't give up! Work hard, ask for help, and you'll get it next time.");
        }
    }
}
    
