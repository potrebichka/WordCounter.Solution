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
            string sentence, word;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a sentence:");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    sentence = Console.ReadLine();
                    Console.ResetColor();
                    if (RepeatCounter.checkIfInputIsValid(sentence))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. No symbols are allowed.");
                    }
                }
                Console.WriteLine();
                while (true)
                {
                    Console.WriteLine("Enter a word:");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    word = Console.ReadLine();
                    Console.ResetColor();
                    if (RepeatCounter.checkIfInputIsValid(word))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. No symbols are allowed.");
                    }
                }
                
                Console.WriteLine();

                int count = RepeatCounter.Count(sentence, word);

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