using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("Indique su edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Su edad es: " + edad);

        Console.Write("Indique su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine($"Su nombre es: {nombre} ");
    }
}