using System;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Square s1 = new Square("Red", 3);
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