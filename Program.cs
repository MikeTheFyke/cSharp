using System;
using System.Collections.Generic; // Fourteenth Git to allow usage of lists.

namespace csharp
{

    class Jedi  // Nineteenth git
    {
        public string name;
        public string forceAbility;
        public int forcePower;
        public float experience;

        public void useForce()
        {
            if (forcePower > 0){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n" + name + " uses " + forceAbility + " .");
                forcePower--; // everytime the force is used forcedpower is decreased. 
                experience += 0.3f;  
                Console.ForegroundColor = ConsoleColor.White; 
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(name + " does not have enough force power available.");
                Console.ForegroundColor = ConsoleColor.White; 
            }

        }

        public void forceMeditate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name + " meditates to regain connection with the force.");
            forcePower += 2;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

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
            // double answer01 = 16;
            // double userAnswer01;
            // double answer02 = 0;
            // double userAnswer02;
            // double answer03 = 130;
            // double userAnswer03;
            // int score = 0;

            // Console.WriteLine("Okay we are here to test you math skills.\n Can you please tell me the answer of the following questions.\n1. What is 8 * 2 ? ");
            // userAnswer01 = Convert.ToDouble (Console.ReadLine());
            // if (userAnswer01 == answer01){
            //     score = score + 1;
            //     Console.WriteLine("Correct !");
            // } else {
            //     Console.WriteLine("Great job but wrong dumbass.");
            // }
            // Console.WriteLine("2. What is Answer01 - 16 ? ");
            // userAnswer02 = Convert.ToDouble (Console.ReadLine());
            // if (userAnswer02 == answer02){
            //     score = score + 1;
            //     Console.WriteLine("Correct !");
            // } else {
            //     Console.WriteLine("Great job but wrong dumbass.");
            // }
            // Console.WriteLine("3. What is 13 with Answer02 on the end ? ");
            // userAnswer03 = Convert.ToDouble (Console.ReadLine());
            // if (userAnswer03 == answer03){
            //     score = score + 1;
            //     Console.WriteLine("Correct !");
            // } else {
            //     Console.WriteLine("Great job but wrong dumbass.");
            // }
            // Console.WriteLine("Great your final score is : " + score + " .");

            // Eighth Git
            // Console.Write("Input a number between 1 and 5 : ");
            // int num = Convert.ToInt32(Console.ReadLine());

            // switch (num){
            //     case 1:
            //         Console.WriteLine("One");
            //         break;
            //     case 2:
            //         Console.WriteLine("Two");
            //         break;
            //     case 3:
            //         Console.WriteLine("Three");
            //         break;
            //     case 4:
            //         Console.WriteLine("Four");
            //         break;
            //     case 5:
            //         Console.WriteLine("Five");
            //         break;
            //     default:
            //         Console.WriteLine("I said between 1 and 5 !");
            //         break;
            // }

            // Ninth Git
            // Console.WriteLine("Please enter a number to start our power of loop at : ");
            // double startNumber = Convert.ToDouble (Console.ReadLine());
            // Console.WriteLine("Please enter the number of times your would like " + startNumber + " to be powered by : ");
            // double powerNumber = Convert.ToDouble (Console.ReadLine());

            // for (int i = 1; i <= powerNumber; i++ ){
            //     double result = Math.Pow(startNumber, i); // Power of method starting at 2 and to the power of i.
            //     Console.WriteLine(i + ". " + result);
            // }

            // Tenth Git - One Dice
            // Random numberGen = new Random(); 

            // int roll = 0;
            // int attempts = 1;
            // Console.WriteLine("Please press enter to roll the die.");
            // while (roll!=6){
            //     Console.ReadKey(); // Waits for user to press a key to start the while loop.

            //     roll = numberGen.Next(1,7); // next function between 1 (inclusive - min) & 7 (exclusive - max)
            //     Console.WriteLine(attempts + ". You Rolled a " + roll + ".");
            //     attempts++;
            //     Console.WriteLine("Please press enter to roll the die.");
            // }
            // Console.WriteLine("You took " + attempts + " attempts to roll a 6.");

            // Eleventh Git - Two Dice
            // Random numberGen = new Random();

            // int roll01 = 0;
            // int roll02 = 0;
            // int attempts = 0;
            // Console.WriteLine("Please press enter to roll the die.");
            // while (roll01!=6 || roll02!=6){
            //     Console.ReadKey(); // Waits for user to press a key to start the while loop.
            //     attempts++;
            //     roll01 = numberGen.Next(1,7); // next function between 1 (inclusive - min) & 7 (exclusive - max)
            //     roll02 = numberGen.Next(1,7);
            //     Console.WriteLine(attempts + ". You Rolled a " + roll01 + ".");
            //     Console.WriteLine(attempts + ". You Rolled a " + roll02 + ".");
            //     Console.WriteLine("Please press enter to roll the die.");
            // }
            // Console.WriteLine("You took " + attempts + " attempts to roll double 6's.");

            // Twelfth Git

            // string[] movies = {
            //     "They Live",
            //     "Return Of The Jedi",
            //     "Metropolis",
            //     "Falling Down"
            // };

            // for (int i = 0; i < movies.Length; i++){
            //     int rank = i + 1;
            //     Console.WriteLine(rank + ". " + movies[i]);
            // };

            // Thirteenth Git - Array with set number of indexes.

            // string[] movies = new string [4];

            // Console.WriteLine("Please enter your four favorite movies : ");
            
            // for (var i = 0; i < movies.Length; i++){
            //     movies[i] = Console.ReadLine();
            // }
            // movies[0] = Console.ReadLine();
            // movies[1] = Console.ReadLine();
            // movies[2] = Console.ReadLine();
            // movies[3] = Console.ReadLine();

            // Console.WriteLine("\nHere they are alphabetically : ");

            // Array.Sort(movies); // Sorts array Alphabetically.

            // for (var i  = 0; i < movies.Length; i++){
            //     Console.WriteLine(movies[i]);
            // };

            // Fourteenth Git - List Array notice the added 'using System.Collections.Generic;' at top of page.

            // List<string> shoppingList = new List<string>();

            // shoppingList.Add("Shibbles");
            // shoppingList.Add("Fibbles");
            // shoppingList.Add("Gribbles");
            // shoppingList.Add("Dribbles");

            // for (var i = 0; i < shoppingList.Count; i++){ // When Working with lists we use Count instead of length.
            //     Console.WriteLine(shoppingList[i]);
            // };

            // shoppingList.Remove("Fibbles"); // Removes list item by value
            // shoppingList.RemoveAt(2); // Removes list item by indices.

            // Console.WriteLine("Your new list");

            // for (var i = 0; i < shoppingList.Count; i++){
            //     Console.WriteLine(shoppingList[i]);
            // };

            // Fifteenth Git

            // List<string> passengerList = new List<string>();

            // Console.Write("How many people are going to the moon : ");
            // int numPeople = Convert.ToInt32 (Console.ReadLine());
            // Console.WriteLine("There are " + numPeople + " going to the moon today.");

            // Console.WriteLine("What are the passengers names ? ");
            // for (var i = 0; i < numPeople; i++){
            //     int rank = i + 1;
            //     Console.Write(rank + ". ");
            //     passengerList.Add(Console.ReadLine());
            // };

            // passengerList.Sort(); // Sort method when using Lists

            // Console.WriteLine("---------------Here is a List of Passengers Alphabetically.---------------");

            // for (var i = 0; i < numPeople; i++){
            //     int rank = i + 1;
            //     Console.WriteLine(rank + ". " + passengerList[i]);
            // };

            // Sixteenth Git - Creating Methods (functions) - MeetAlien

            // MeetAlien();
            // Console.WriteLine("---");
            // MeetAlien();
            // Console.WriteLine("---");
            // MeetAlien();

            // Seventeenth Git - Multiply Method with a return 'result' back to main.

            // int newResult = Multiply(3, 3); // can be same or not of what is returned from method
            // Console.WriteLine("The result is " + newResult);

            // if (newResult % 2 == 0){ // modulous % sign
            //     Console.WriteLine(newResult + " is an even number.");
            // } else {
            //     Console.WriteLine(newResult + " is not an even number.");
            // }

            // Eighteenth Git - Word Splitter Challenge

            // Console.WriteLine("Please enter a sentence to split.");
            // string sentence = Console.ReadLine();

            // int wordCount = Splitter(sentence);

            // Console.WriteLine("There are " + wordCount + " words in your sentence.");

            // Nineteenth Git

            Jedi jedi01 = new Jedi();
            jedi01.name = "Miku Fyku";
            jedi01.forceAbility = "Force Choke";
            jedi01.forcePower = 3;
            jedi01.experience = 0f;
            
            jedi01.useForce();
            Console.WriteLine(jedi01.name + " currently has " + jedi01.forcePower + " force power available.");
            Console.WriteLine(jedi01.name + " has gained " + jedi01.experience + " force experience.\n");

            jedi01.forceMeditate();
            Console.WriteLine(jedi01.name + " currently has " + jedi01.forcePower + " force power available.");
            Console.WriteLine(jedi01.name + " has gained " + jedi01.experience + " force experience.\n");
            
            Console.ReadKey(); // waits for a key input before closing.
        }
        // static void MeetAlien(){ // Created for Sixteenth Git - 
        //     Random numberGen = new Random();
        //     string name = "X-" + numberGen.Next(20, 9999);
        //     int age = numberGen.Next(18, 500);
        //     Console.WriteLine("Hi, I'm " + name + ".\nI'm " + age + " solar cycles old.\nOh and it looks like you are an alien ;)\nI'm really into that.");
        // }

        // static int Multiply (int num01, int num02){ // Seventeeth Git - void is changed to what we want to return from this method 'int'.
        //     int result = num01 * num02;
        //     // Console.WriteLine("The result is: " + result); // when void is used we display through the method.
        //     return result; // with 'static int' in the head of this method we can return 'result' to our main.
        // }

        // static int Splitter (string sentence){ // Eighteenth Git
        //     int counted = sentence.Split(' ').Length;
        //     return counted;
        // }

    }
}
