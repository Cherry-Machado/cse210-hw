using System;
using System.Collections.Generic;
using System.IO;

// CSE210 Programming with Classes.
// Cherry Machado.

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hello World! This is my EternalQuest Project.");
            Console.WriteLine("");
            new GoalManager().Start();
        }
    }
}