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
            RepeatCounter instanceOfRepeatCounter = new RepeatCounter("", "");
            Assert.AreEqual(typeof(RepeatCounter), instanceOfRepeatCounter.GetType());
        }
    }
}
