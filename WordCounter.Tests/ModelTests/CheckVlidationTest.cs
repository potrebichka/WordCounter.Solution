using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class  CheckValidationTest
    {
        [TestMethod]
        public void RepeatCounter_CheckValidationLetters_True()
        {
            bool result = RepeatCounter.checkIfInputIsValid("cat");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RepeatCounter_CheckValidationDigits_True()
        {
            bool result = RepeatCounter.checkIfInputIsValid("cat is 4. 4Cat.");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RepeatCounter_CheckValidationSymbol_False()
        {
            bool result = RepeatCounter.checkIfInputIsValid("$cats");
            Assert.AreEqual(false, result);
        }
    }
}