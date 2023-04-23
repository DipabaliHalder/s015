using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your age? ");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Your maximum heart rate should be {0} beats per minute",220-age);
            Console.WriteLine("Your target HR Zone is {0} - {1} beats per minute",0.5*(220-age),Math.Round(0.85*(220-age)));                    
        }
    }
}
