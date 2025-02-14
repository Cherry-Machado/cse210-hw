using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

// Class: CSE 210 : Programación con clases
// Student: Cherry Machado

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();

        Circle s3 = new Circle("Green", 4);
        shapes.Add(s3);

        Rectangle s2 = new Rectangle("Blue", 7, 8);
        shapes.Add(s2);

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        foreach (Shape s in shapes)
        {
            //GetColor method from the base class
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }

    }
}