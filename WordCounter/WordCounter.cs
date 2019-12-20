using System;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Word Counter Program");
            while (true)
            {
                Console.WriteLine("Enter a sentence:");
                string sentence = Console.ReadLine();
                Console.WriteLine("Enter a word:");
                string word = Console.ReadLine();
                RepeatCounter counter = new RepeatCounter(sentence, word);
                int count = counter.Count();
                Console.WriteLine($"Word '{word}' appears in sentence '{sentence}'  {count} times");
                bool flag = false;
                while (true)
                {
                    Console.WriteLine("Do you want to repeat?[yes,no]");
                    string userInput = Console.ReadLine();
                    if (userInput == "yes")
                    {
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

        }
    }
}