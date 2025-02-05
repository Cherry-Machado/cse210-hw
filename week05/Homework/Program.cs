using System;
using System.Collections.Generic;

// CSE210 Programming with Classes.
// Cherry Machado.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine("");

        Assignment assigment = new Assignment("Jose", "Matematicas");
        string juntos = assigment.GetSummary();
        Console.WriteLine(juntos);
        Console.WriteLine("--------------------------");

        MathAssignment mathAssignment = new MathAssignment("Roberto", "Quimica", "7.3", "8-9");
        string mathJuntos = mathAssignment.GetSummary();
        string mathHomeworks = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathJuntos);
        Console.WriteLine(mathHomeworks);
        Console.WriteLine("--------------------------");
        
        WritingAssignment writingAssignment = new WritingAssignment("Jose", "Leguaje", "Las primeras letras del Espanol");
        string writingInforJuntos = writingAssignment.GetSummary();
        string writingJuntos = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingJuntos);
        Console.WriteLine(writingInforJuntos);
    }
}