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

    public class ReverseStringTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("This is my string", "gnirts ym si sihT")]
        [TestCase("Hello world!", "!dlrow olleH")]
        [TestCase("The quick brown fox jumps over the lazy dog", "god yzal eht revo spmuj xof nworb kciuq ehT")]
        public void GivenAnInputOfString_Return_ReversedString(string input, string expResult)
        {
            
            string reversed = Method.ReverseString(input);
            Assert.That(reversed, Is.EqualTo(expResult));
        }

        [TestCase("This is my string")]
        public void GivenAString_Return_ReversedString(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);

            Assert.That(Method.ReverseStringStack(input), Is.EqualTo(new string(inputArray)));
        }
    }

    public class TwoElementsTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 2, 3, 1, 7, 9, 5, 11, 3, 5 }, 10)]
        [TestCase(new int[] { 2, 5, 2, 1, 9, 5, 23, 3, 5 }, 22)]
        public void GivenAnArrayOfIntegers_Return_CorrectMaximumDifference(int[] nums, int expResult)
        {
            Assert.That(() => Method.DiffBetweenTwoElements(nums), Is.EqualTo(expResult));
        }

        [Test]
        public void GivenAnArrayWithNullElements_Throw_Exception()
        {
            Assert.That(() => Method.DiffBetweenTwoElements(null),Throws.TypeOf<ArgumentException>());
        }

        [TestCase(new int[] { 2 })]
        public void GivenAnArrayWithLessThanTwoElements_Throw_Exception(int[] nums)
        {
            Assert.That(() => Method.DiffBetweenTwoElements(nums),Throws.TypeOf<ArgumentException>());
        }
    }

    public class TemperatureTests
    {
        [TestCase("celsius", 0f, 32f)]
        [TestCase("fahrenheit", 32f, 0f)]
        [TestCase("celsius", -69f, -92.2f)]
        [TestCase("fahrenheit", -100f, -73.3f)]
        public void GivenASelectedUnitAndInputOfTemperature_Return_CorrectConversion (string unit, float input, float expResult)
        {
            Assert.That(() => Method.ConvertTemperature(unit, input), Is.EqualTo(expResult).Within(0.1));
        }
    }

    public class AverageMarksTests
    {
        [TestCase("20 100 50", 56.67f)]
        [TestCase("30 70 90", 63.33f)]
        [TestCase("44 62 21 51 11", 37.80f)]
        public void GivenAStringOfNumbers_Return_CorrectAverageMark(string input, float expResult)
        {
            Assert.That(() => Method.AverageMarks(input), Is.EqualTo(expResult).Within(0.01));
        }

        [Test]
        public void GivenAStringOfNull_Throw_ArgumentException()
        {
            Assert.That(() => Method.AverageMarks(null), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void GivenAStringContainingNegativeNumbers_Throw_ArgumentException()
        {
            Assert.That(() => Method.AverageMarks("-1"), Throws.TypeOf<ArgumentException>());
        }
    }

    public class CharacterIdentifierTests
    {
        [TestCase("a","vowel")]
        public void GivenAStringInput_Return_CorrectVowelOrConsonant(string input, string expResult)
        {
            Assert.That(() => Method.CharacterIdentifier(input), Is.EqualTo(expResult));
        }
    }

    public class ReturnStringTest
    {
        [TestCase(new int[] { 1, 2, 3, 4 },"1234")]
        public void GivenAnInputOfAStringOfIntegers_Return_Integers(int[] input, string expResult)
        {
            Assert.That(() => Method.ReturnString(input), Is.EqualTo(expResult));
        }
    }

    public class AnimalYearTests
    {
        [TestCase(1, new int[] { 1, 15, 15 })]
        [TestCase(2, new int[] { 2, 24, 24 })]
        [TestCase(3, new int[] { 3, 28, 29 })]
        [TestCase(10, new int[] { 10, 56, 64 })]
        public void GivenAnInputOfHumanYears_Return_CorrectCatAndDogAge(int input, int[] expResult)
        {
            Assert.That(() => Method.humanYearsCatYearsDogYears(input), Is.EqualTo(expResult));
        }

        [Test]
        public void GivenAnInputLessThanOne_Throw_Exception()
        {
            Assert.That(()=> Method.humanYearsCatYearsDogYears(-1), 
                Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contains("Specified argument was out of the range of valid values."));
        }
    }

    public class ClosestToZeroTests
    {
        [TestCase(new int[] { 2, 8, 1, 4, 2, 6, 7, 3, 4, 9 }, 1)]
        [TestCase(new int[] { 2, 8, 3, 4, 4, 6, 7, 3, 4, 9 }, 2)]
        [TestCase(new int[] { 11, 12, 13, 14, 14, 16, 10, 13, 14, 19 }, 10)]
        [TestCase(new int[] { 11, 12, 13, 14, -1, 16, 10, 13, 14, 19 }, -1)]
        [TestCase(new int[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }, 2)]
        public void GivenAnArrayOfInts_NumberClosestToZeroIsReturned(int[] input, int expResult)
        {
            Assert.That(Method.NumberClosestToZero2(input), Is.EqualTo(expResult));
        }

        [TestCase(new int[] { }, 0)]
        public void GivenAnArrayContainingNulls_Throw_NullException()
        {
            Assert.That(() => Method.NumberClosestToZero2(null),
                Throws.TypeOf<ArgumentNullException>().With.Message.Contains("Value cannot be null."));
        }
    }

    public class GroupedByCommasTests
    {
        [TestCase(1, "1")]
        [TestCase(12, "12")]
        [TestCase(123, "123")]
        [TestCase(1234, "1,234")]
        [TestCase(12345, "12,345")]
        [TestCase(123456, "123,456")]
        [TestCase(1234567, "1,234,567")]
        [TestCase(12345678, "12,345,678")]
        [TestCase(123456789, "123,456,789")]
        [TestCase(1234567890, "1,234,567,890")]
        public void GivenAnInputOfAnInt_InsertCommaAtCorrectLocationAndReturnAsString(int input, string expResult)
        {
            Assert.That(Method.GroupedByCommas(input), Is.EqualTo(expResult));
        }
    }

    public class WhoLikesItTests
    {
        [Test, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.AreEqual("no one likes this", Method.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Method.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Method.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Method.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Method.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }

    public class IsAFibonacciNumber
    {
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(5, true)]
        [TestCase(8, true)]
        [TestCase(13, true)]
        [TestCase(21, true)]
        [TestCase(34, true)]
        [TestCase(55, true)]
        [TestCase(89, true)]
        public void GivenAnInputNumber_Return_True_IfInputNumberIsAFibonacciNumber(int input, bool expResult)
        {
            Assert.That(Method.IsThisAFibonacciNumber(input), Is.EqualTo(expResult));
        }
    }
}