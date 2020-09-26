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
            // double num01;
            // double num02;
            // string operation;
            // double result;

            // Console.Write("Input the first number please : "); // Write instead of writeline waits for answer (ReadLine) on same line.
            // // num01 = Convert.ToInt32 (Console.ReadLine()); // Convert string input to int or float or double
            // num01 = Convert.ToDouble (Console.ReadLine());
            // Console.Write("Input a second number please : "); // Write instead of writeline waits for answer (ReadLine) on same line.
            // // num02 = Convert.ToInt32 (Console.ReadLine());
            // num02 = Convert.ToDouble (Console.ReadLine());
            // Console.Write("Input type of operation please (+ - * /) : ");
            // operation = Console.ReadLine();
            // if (operation == "+"){
            //     result = num01 + num02;
            //     Console.WriteLine("Your Result is " + result + ".");
            // } else if (operation == "-")  {
            //     result = num01 - num02;
            //     Console.WriteLine("Your Result is " + result + ".");
            // } else if (operation == "*")  {
            //     result = num01 * num02;
            //     Console.WriteLine("Your Result is " + result + ".");
            // } else if (operation == "/")  {
            //     result = num01 / num02;
            //     Console.WriteLine("Your Result is " + result + ".");
            // }

            // Fifth Git
            // double cash;
            // Console.WriteLine("Welcome to the Vitual show!\nTickets cost $5.\nCan you please pay to continue.");
            // cash = Convert.ToDouble (Console.ReadLine());
            // if (cash < 5){
            //     Console.WriteLine("Sorry not enough money, goodbye.");
            // } else if (cash == 5){
            //     Console.WriteLine("Great job exact amount, you may proceed.");
            // } else {
            //     double change = cash - 5;
            //     Console.WriteLine("Great job here is you change $" + change + ".");
            // }

            // Sixth Git
            // int age;
            // int height;

            // Console.Write("Welcome you the vitual amusment park.\nCan you please input your age ? ");
            // age = Convert.ToInt32 (Console.ReadLine());

            // Console.Write("Can you please input your height in cm ? ");
            // height = Convert.ToInt32 (Console.ReadLine());

            // if (age >= 18 && height >= 160){
            //     Console.WriteLine ("Great Come Aboard :) !!");
            // } else if (age < 18){
            //     Console.WriteLine ("Sorry your not old enough to ride :(");
            // } else if (height < 160){
            //     Console.WriteLine ("Sorry you are not tall enough to ride :(");
            // }

            // Seventh Git
            double answer01 = 16;
            double userAnswer01;
            double answer02 = 0;
            double userAnswer02;
            double answer03 = 130;
            double userAnswer03;
            int score = 0;

            Console.WriteLine("Okay we are here to test you math skills.\n Can you please tell me the answer of the following questions.\n1. What is 8 * 2 ? ");
            userAnswer01 = Convert.ToDouble (Console.ReadLine());
            if (userAnswer01 == answer01){
                score = score + 1;
                
            }
            Console.WriteLine("2. What is Answer01 - 16 ? ");
            userAnswer02 = Convert.ToDouble (Console.ReadLine());
            if (userAnswer02 == answer02){
                score = score + 1;
            }
            Console.WriteLine("3. What is 13 with Answer02 on the end ? ");
            userAnswer03 = Convert.ToDouble (Console.ReadLine());
            if (userAnswer03 == answer03){
                score = score + 1;
            }
            Console.WriteLine("Great your final score is : " + score + " .");


            Console.ReadKey(); // waits for a key input before closing.
        }
    }
}
