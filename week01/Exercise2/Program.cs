using System;

class Program
{
    static void Main(string[] args)
    {
        //Author: CherryMachado
        //Purpose: Determine and display letter grades, including +/-.
        //Restrictions: None
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
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

        string sign = "";
        int lastDigit = grade % 10;
        if (lastDigit >= 7) 
            {
                sign = "+";
            }
        else if (lastDigit < 3)
            {
                sign = "-";
            }
        else
            {
                sign = "";
            }
        if (grade >= 93)
        {
            sign = "";           
        }
        if (letter == "F")
        {
            sign = "";
        }
        Console.WriteLine($"Your letter grade is: {letter}{sign}.");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }
    }
}