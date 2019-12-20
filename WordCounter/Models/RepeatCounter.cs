using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class RepeatCounter
    {
        public string Sentence {get;set;}
        public string Word {get;set;}
        private int _count = 0;
        public RepeatCounter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
        }
        public int Count()
        {
            return _count;
        }
    }
}