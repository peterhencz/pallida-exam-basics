using NUnit.Framework;
using System;
using System.Collections.Generic;
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

        [Test]
        public void AddToList_WhenEmptyString_ThenEmptyList()
        {
            string input = string.Empty;
            var output = new List<char>();
            Assert.AreEqual(output, uniqueCharacter.UniqueCharacters(input));
        }

        [Test]
        public void AddToList_WhenAnagramUpperCase_ThenAngrm()
        {
            string input = "Anagram";
            var output = new List<char>() { 'A', 'n', 'g', 'r', 'm'};
            Assert.AreEqual(output, uniqueCharacter.UniqueCharacters(input));
        }
    }
}
