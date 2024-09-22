using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.WriteLine("Hello! What is your name?");
        
        // Read the user's input
        string name = Console.ReadLine();

        // Greet the user by name
        Console.WriteLine($"Nice to meet you, {name}!");
    }
}