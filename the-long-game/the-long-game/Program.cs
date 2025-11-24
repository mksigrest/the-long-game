using System;
using System.IO;

namespace theLongGame
{
    internal class program
    {
        static void Main(string[] args)
        {
            string name;
            int score = 0;
            bool i = false;

            Console.Write("Hello Player, what is your name?: ");
            name = Console.ReadLine();

            string filePath = $"{name}.txt";

            if (File.Exists(filePath))
            {
                string oldTxt = File.ReadAllText(filePath);
                if (int.TryParse(oldTxt, out int oldScr))
                {
                    score = oldScr;
                    Console.WriteLine($"Welcome back {name}! Your previous score is {score}.");
                }
            }
            else
            {
                Console.WriteLine($"Hello {name}! Are you ready to compete?");
            }

            Console.WriteLine("When you are done, press enter to finish.");
            Console.WriteLine("Your button pressing begins now!");

            while (i == false)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    i = true;
                }
                else
                {
                    score++;
                    Console.WriteLine();
                    Console.WriteLine($"Your score is: {score}");
                    Console.WriteLine($"You pressed the {keyInfo.Key} key");
                }
            }
        }
    }
}