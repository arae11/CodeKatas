using NUnit.Framework;
using CodeKataMethods;
using System;

namespace CodeKataTests
{
    public class DuplicateTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Nishant Mandal", new char[] { 'n', 'a' })]
        [TestCase("Martin Beard", new char[] { 'a', 'r' })]
        [TestCase("Alex Rae", new char[] { 'a', 'e' })]
        public void GivenAString_Return_Correct_ArrayOfDuplicateCharacters(string input, char[] expChar)
        {
            var charArray = Method.ReturnDuplicate(input);
            Assert.That(charArray, Is.EqualTo(expChar));
        }

        [TestCase("Alex")]
        public void GivenAStringWithNoDuplicates_Return_EmptyArray(string input)
        {
            var charArray = Method.ReturnDuplicate(input);
            Assert.That(charArray.Length, Is.EqualTo(0));
        }
    }

    public class FibonacciTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(44, 1_836_311_902)]
        [TestCase(27, 514228)]
        [TestCase(26, 317810)]
        [TestCase(13, 609)]
        [TestCase(6, 20)]
        [TestCase(1, 1)]
        public void GivenAnInputOfN_Return_CorrectSumOfFibonacciNumbersUpToN(int input, int expTotal)
        {
            int sequence = Method.FibonacciNumbers(input);
            Assert.That(sequence, Is.EqualTo(expTotal));
        }

        [Test]
        public void GivenANegativeInputOfN_Throw_Exception()
        {
            Assert.That(() => Method.FibonacciNumbers(-1), 
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Specified argument was out of the range of valid values."));
        }

        [Test]
        public void GivenAnInputOfNResultingInOverflow_Throw_Exception()
        {
            Assert.That(() => Method.FibonacciNumbers(45), 
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Specified argument was out of the range of valid values."));
        }
    }
}