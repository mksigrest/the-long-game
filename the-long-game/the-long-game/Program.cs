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

            }

            Console.WriteLine("Hello " + name + "! Are you ready to compete?");
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