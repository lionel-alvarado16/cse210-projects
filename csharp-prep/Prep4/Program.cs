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
        
        foreach (int number in numbers)
        {
            sum += number;

            if (number > largestNum)
            {
                largestNum = number;
            }
        }

        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}