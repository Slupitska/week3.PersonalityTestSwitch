using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personality test
            //приложение просит пользователя ввести его любимый цвет
            //и на основе введенного значения консоль показывает пользователю некоторую обратную связь
            //red - you are so romantic
            //blue - you are a workaholic
            //green - you care about the environment
            //любой другой цвет - you are a {userInput} unicorn

            Console.WriteLine("Please enter your favorite color:");
            string userInput = Console.ReadLine().ToLower(); //RED/reD/ReD/rED --> red
            
            switch (userInput)
            {
                case "red":
                    Console.WriteLine("You are so romantic.");
                    break;
                case "blue":
                    Console.WriteLine("You are a workaholic.");
                    break;
                case "green":
                    Console.WriteLine("You care about the environment.");
                    break;
                default:
                    Console.WriteLine($"You are a {userInput} unicorn.");
                    break;
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}
