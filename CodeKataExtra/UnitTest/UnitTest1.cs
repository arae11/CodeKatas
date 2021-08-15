using NUnit.Framework;

namespace CodeKataTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Nish Mandal", "nana")]
		public void GivenAString_Return_Correct_ArrayOfDuplicatesCharacters(string input, char[] expResult)
		{
            var charArray = input.ToCharArray();
			Assert.That(charArray, Is.EqualTo(expResult));
		}
    }
}