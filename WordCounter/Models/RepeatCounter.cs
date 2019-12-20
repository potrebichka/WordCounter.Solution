using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Sentence {get;set;}
        public string Word {get;set;}
        public RepeatCounter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
        }
        public int Count()
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