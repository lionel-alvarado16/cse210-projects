using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int num = -1;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        int sum = 0;
        int largestNum = 0;
        int minPos = 999999;
        
        foreach (int number in numbers)
        {
            
            // Compute the sum
            sum += number;

            // Finding the largest number
            if (number > largestNum)
            {
                largestNum = number;
            }

            // Finding the smallest positive number
            if ((number < minPos) && (number > 0))
            {
                minPos = number;
            }
        }

        // Compute the average
        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {minPos}");

        // Sorting the list
        numbers.Sort();

        Console.WriteLine($"The sorted list is: ");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}