using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void RepeatCounter_WordNotEncounterInSentence_Zero()
        {
            int result = RepeatCounter.Count("Just a plain sentence.", "cat");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentenceSingleWords_Count()
        {
            int result = RepeatCounter.Count("A cat sentence with a cat.", "cat");
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentenceCaseSensitive_Count()
        {
            int result = RepeatCounter.Count("Cat hates dog.", "cat");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentenceInsideOtherWords_Count()
        {
            int result = RepeatCounter.Count("A sentence with a cathedral", "cat");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentence_Count()
        {
            int result = RepeatCounter.Count("A cat sentence with a cathedral", "cat");
            Assert.AreEqual(1, result);
        }
    }
}
