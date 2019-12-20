using System;
using System.Drawing;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Welcome to Word Counter Program");
            Console.ResetColor();
            while (true)
            {
                Console.WriteLine("Enter a sentence:");
                Console.ForegroundColor = ConsoleColor.Blue;
                string sentence = Console.ReadLine();
                Console.ResetColor();
                Console.WriteLine("Enter a word:");
                Console.ForegroundColor = ConsoleColor.Blue;
                string word = Console.ReadLine();
                Console.ResetColor();
                RepeatCounter counter = new RepeatCounter(sentence, word);
                int count = counter.Count();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Word '{word}' appears in sentence '{sentence}'  {count} times");
                Console.ResetColor();
                Console.WriteLine("------------------------");
                bool flag = false;
                while (true)
                {
                    Console.WriteLine("Do you want to repeat?[yes,no]");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    string userInput = Console.ReadLine();
                    Console.ResetColor();
                    if (userInput == "yes")
                    {
                        Console.WriteLine("------------------------");
                        break;
                    }
                    else if (userInput == "no")
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag) 
                {
                    break;
                }

            }
            Console.ResetColor();
        }
    }
}