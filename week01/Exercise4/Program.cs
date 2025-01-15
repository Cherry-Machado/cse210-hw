using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Author: CherryMachado
        //Purpose: Appending numbers in a list.

        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("");
        // Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine("Enter a list of numbers, (positive and negative) type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = 1;
        while (number != 0)
        {
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        float sum = 0;
        int largestNumber = numbers[0];
        foreach (int num in numbers)
        {   
            sum += num;
            if (num > largestNumber)
            {
                largestNumber = num;
            }
        }
        int theSmallestPositiveNumber = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0 && num < theSmallestPositiveNumber)
            {
                theSmallestPositiveNumber = num;
            }
        }

       
        Console.WriteLine($"The sum of the numbers is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number in the list is: {largestNumber}");
        Console.WriteLine($"The smallest positive number in the list is: {theSmallestPositiveNumber}");
        Console.Write("The sorted list is: ");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.Write(num);
            Console.Write(" ");
        }
    }
}