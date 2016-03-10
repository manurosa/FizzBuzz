using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var fizzResult = método aplicado a 3
            //var buzzResult= método aplicado a 5
            //var fizzBuzzRestuls= método aplicado a 15
            Assert.AreEqual(fizzResult, "fizz");
            Assert.AreEqual(buzzResult, "buzz");
            Assert.AreEqual(fizzBuzzresult, "fizzbuzz");
        }
    }
}
