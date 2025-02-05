using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine("");

        Assignment assigment = new Assignment("Jose", "Matematicas");
        string juntos = assigment.GetSummary();
        MathAssignment mathAssignment = new MathAssignment("Roberto", "Quimica", "7.3", "8-9" );
        Console.WriteLine(juntos);
        string mathJuntos = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathJuntos);
    }
}