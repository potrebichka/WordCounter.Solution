using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void InstVarConstructor_CreatesInstanceOfRepeatCounter_Instance()
        {
            RepeatCounter testInstance = new RepeatCounter("", "");
            Assert.AreEqual(typeof(RepeatCounter), testInstance.GetType());
        }
        [TestMethod]
        public void RepeatCounter_WordNotEncounterInSentence_Zero()
        {
            RepeatCounter testInstance = new RepeatCounter("Just a plain sentence.", "cat");
            int result = testInstance.Count();
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentence_Count()
        {
            RepeatCounter testInstance = new RepeatCounter("A cat sentence with a cat.", "cat");
            int result = testInstance.Count();
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void RepeatCounter_WordEncounterInSentenceCaseSensitive_Count()
        {
            RepeatCounter testInstance = new RepeatCounter("Cat hates dog.", "cat");
            int result = testInstance.Count();
            Assert.AreEqual(1, result);
        }
    }
}
