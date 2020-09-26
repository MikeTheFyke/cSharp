using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Initial Git
            // Console.WriteLine("Hello World!");
            // Console.ReadLine();

            // Second Git
            // Console.Title = "Mike Title";
            // Console.ForegroundColor = ConsoleColor.Red;
            // Console.WindowHeight = 40;
            // Console.WriteLine("Hello, whats your name ?");
            // Console.ReadLine();
            // Console.WriteLine("Nice to meet you.\nMy name is Hal,\n do you like daisies ?");
            // Console.ReadLine();
            // Console.ReadKey();

            // Third Git
            Console.WriteLine("Hello what is your name ?");
            string username = Console.ReadLine();
            Console.WriteLine("Nice to mee you " + username + ". My name is Hal, do you like daisies " + username + " ?");
            string userAnswer = Console.ReadLine();
            if (userAnswer == "yes"){
                Console.WriteLine("Good, perfect answer.");
            } else {
                Console.WriteLine("Thats fine, more for me :)");
            }
        }
    }
}
