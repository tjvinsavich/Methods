using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserInput("Hey! What is your name?");
            string color = GetUserInput("What's your favorite color?");
            string animal = GetUserInput("What's your favorite animal?");
            string villain = GetUserInput("What's the name of someone you can't stand?");

            GenerateMadLib(name, color, animal, villain);
        
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static void GenerateMadLib(string name, string color, string animal, string villain)
        {
            string madLib = $"Once upon a time, {name} was taking their pet {color} {animal} for a walk. " +
                $"Suddenly, {villain} jumped out of nowhere and snatched their beloved {animal} away! " +
                $"Since that day, {name} has sworn vengeance and is setting out on their journey to become... " +
                $"ULTIMATE {name.ToUpper()}!!!";

            Console.WriteLine(madLib);
        }
    }
}
