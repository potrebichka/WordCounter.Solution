using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public static class RepeatCounter
    {
        public static bool checkIfInputIsValid(string text)
        {
            char[] arr = text.Where(Char.IsSymbol).Distinct().ToArray();
            if (arr.Length > 0)
            {
                return false;
            }
            return true;
        }
        public static int Count(string Sentence, string Word)
        {
            int count = 0;
            if ((Sentence.Length == 0) || (Word.Length == 0))
            {
                return 0;
            }

            char[] punctuation = Sentence.Where(Char.IsPunctuation).Distinct().ToArray();
            var wordArray = Sentence.ToLower().Split().Select(x => x.Trim(punctuation));
            foreach (string currentWord in wordArray)
            {
                if (currentWord == Word)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}