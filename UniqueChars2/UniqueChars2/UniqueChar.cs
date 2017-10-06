using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueChars2
{
    public class UniqueChar
    {
        public List<char> UniqueCharacters(string input)
        {
            var uniqueList = new List<char>();
            char[] characters = input.ToCharArray();
            var countChars = new Dictionary<char, int>();

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
                if (pair.Value == 1 && pair.Key != ' ')
                {
                    uniqueList.Add(pair.Key);
                }
            }

            return uniqueList;
        }
    }
}
