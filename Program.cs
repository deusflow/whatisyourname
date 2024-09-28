using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name
        Console.WriteLine("Hello! What is your name?");
        
        // Read the user's input
        string name = Console.ReadLine();

        // Check if the user entered a name
        if (string.IsNullOrWhiteSpace(name))
        {
            // Inform the user that no name was entered
            Console.WriteLine("It seems you didn't enter your name. Please try again.");
        }
        else
        {
            // Greet the user by name
            Console.WriteLine($"Nice to meet you, {name}!");

            // Check the length of the name and give feedback
            if (name.Length < 5)
            {
                Console.WriteLine("You have a too short and sweet name!");
            }
            else if (name.Length <= 9)
            {
                Console.WriteLine("Your name has a good length!");
            } 
            else
            {
                Console.WriteLine("Wow, you have a long name!");
            }
        }
    }
}