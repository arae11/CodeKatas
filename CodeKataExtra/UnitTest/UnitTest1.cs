using NUnit.Framework;
using CodeKataMethods;

namespace CodeKataTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Nishant Mandal", new char[] { 'n', 'a' })]
        [TestCase("Martin Beard", new char[] { 'a', 'r' })]
        [TestCase("Alex Rae", new char[] { 'a', 'e' })]
        public void GivenAString_Return_Correct_ArrayOfDuplicateCharacters(string input, char[] expResult)
		{
            var charArray = Method.ReturnDuplicate(input);
			Assert.That(charArray, Is.EqualTo(expResult));
		}

        [TestCase("Alex")]
        public void GivenAStringWithNoDuplicates_Return_EmptyArray(string input)
        {
            var charArray = Method.ReturnDuplicate(input);
            Assert.That(charArray.Length, Is.EqualTo(0));
        }
    }
}