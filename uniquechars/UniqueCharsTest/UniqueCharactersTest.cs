using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars;

namespace UniqueCharsTest
{
    [TestFixture]
    public class UniqueCharactersTest
    {
        UniqueCharacter uniqueCharacter = new UniqueCharacter();

        [Test]
        public void AddToList_WhenAnagram_ThenNgrm ()
        {
            string input = "anagram";
            var output = new List<char>() { 'n', 'g', 'r', 'm' };
            Assert.AreEqual(output, uniqueCharacter.UniqueCharacters(input));
        }
    }
}
