using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine("");

        Assignment assigment = new Assignment("Jose", "Matematicas");
        string name = assigment.GetStudentName();
        string topico = assigment.GetTopic();
        string juntos = assigment.GetSummary();
        Console.WriteLine(name);
        Console.WriteLine(topico);
        Console.WriteLine(juntos);
    }
}