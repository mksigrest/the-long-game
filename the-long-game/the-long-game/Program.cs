using System;

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
            Console.WriteLine("Hello " + name + "! Are you ready to compete?");
            Console.WriteLine("Your button pressing begins now!");

            while (i = false)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    i = true;
                    return;
                }
            }

            
            Console.WriteLine($"You pressed: {keyInfo.Key}");
        }
    }
}