using System;
using NUnit.Framework;

namespace FizzTest
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1,"1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void Test_FizzBuzz_DoIt(int number, string result)
        {
            FizzBuzz.FizzBuzz test = new FizzBuzz.FizzBuzz();

            string fizzResult = test.DoIt(number);

            Assert.AreEqual(fizzResult, result);
        }
    }
}
