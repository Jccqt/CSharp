using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    public class FirstUniqueCharacterInAString
    {
        public int FirstUniqChar(string s)
        {
            var dictionary1 = new Dictionary<char, int>();
            var dictionary2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary1.TryAdd(s[i], i))
                {
                    dictionary2.Add(s[i], 0);
                }
                else
                {
                    dictionary2[s[i]]++;
                }
            }

            foreach (var character in dictionary2)
            {
                if (character.Value == 0)
                {
                    return dictionary1[character.Key];
                }
            }

            return -1;
        }
    }
}
