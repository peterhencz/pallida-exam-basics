using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniqueChars2;

namespace UniqueCharsTest2
{
    [TestFixture]
    public class UniqueCharTest
    {
        UniqueChar uniqueCharacter = new UniqueChar();

        [Test]
        public void AddToList_WhenAnagram_ThenNgrm()
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
            var output = new List<char>() { 'A', 'n', 'g', 'r', 'm' };
            Assert.AreEqual(output, uniqueCharacter.UniqueCharacters(input));
        }

        [Test]
        public void AddToList_WhenTwoWords_ThenWhiteSpaceDontCount()
        {
            string input = "alpaga pallida";
            var output = new List<char>() { 'g', 'i', 'd' };
            Assert.AreEqual(output, uniqueCharacter.UniqueCharacters(input));
        }

    }
}
