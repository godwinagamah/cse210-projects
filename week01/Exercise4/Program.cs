using System;
using System.Collections.Generic; 
using System.Linq;            

class Program
{
    static void Main()
    {
        
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        
        int userNumber = -1; 
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = Convert.ToInt32(Console.ReadLine());

        
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

    
        if (numbers.Count > 0)
        {
            
            int sum = numbers.Sum();

            
            double average = numbers.Average();

            
            int max = numbers.Max();

            
            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}