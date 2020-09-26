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
            // Console.WriteLine("Hello what is your name ?");
            // string username = Console.ReadLine();
            // Console.WriteLine("Nice to mee you " + username + ". My name is Hal, do you like daisies " + username + " ?");
            // string userAnswer = Console.ReadLine();
            // if (userAnswer == "yes"){
            //     Console.WriteLine("Good, perfect answer.");
            // } else {
            //     Console.WriteLine("Thats fine, more for me :)");
            // }

            // Fourth Git
            double num01;
            double num02;

            string operation;

            double result;

            Console.Write("Input the first number please : "); // Write instead of writeline waits for answer (ReadLine) on same line.
            // num01 = Convert.ToInt32 (Console.ReadLine()); // Convert string input to int or float or double
            num01 = Convert.ToDouble (Console.ReadLine());
            Console.Write("Input a second number please : "); // Write instead of writeline waits for answer (ReadLine) on same line.
            // num02 = Convert.ToInt32 (Console.ReadLine());
            num02 = Convert.ToDouble (Console.ReadLine());
            Console.Write("Input type of operation please (+ - * /) : ");
            operation = Console.ReadLine();
            if (operation == "+"){
                result = num01 + num02;
                Console.WriteLine("Your Result is " + result + ".");
            } else if (operation == "-")  {
                result = num01 - num02;
                Console.WriteLine("Your Result is " + result + ".");
            } else if (operation == "*")  {
                result = num01 * num02;
                Console.WriteLine("Your Result is " + result + ".");
            } else if (operation == "/")  {
                result = num01 / num02;
                Console.WriteLine("Your Result is " + result + ".");
            }
            Console.ReadKey(); // waits for a key input before closing.
        }
    }
}
