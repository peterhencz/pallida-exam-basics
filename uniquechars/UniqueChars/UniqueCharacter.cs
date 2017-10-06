using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars
{
    public class UniqueCharacter
    {
        // Create a method called `UniqueCharacters` that takes a string as parameter
        // and returns a list with the unique letters of the given string
        // Create basic unit tests for it with at least 3 different test cases
        // Print the characters from that list in the following format:
        // "n", "g", "r", "m"

        public List<char> UniqueCharacters (string input)
        {
            var uniqueList = new List<char>();

            char[] characters = input.ToCharArray();
            var countChars = new Dictionary<char, int>();

            if (input != null)
            {
                foreach (var character in characters)
                {
                    if (!countChars.ContainsKey(character))
                    {
                        countChars.Add(character, 1);
                    }
                    else
                    {
                        countChars[character]++;
                    }
                }

                foreach (var pair in countChars)
                {
                    if (pair.Value == 1)
                    {
                        uniqueList.Add(pair.Key);
                    }
                }
            }

            return uniqueList;
        }
    }
}
