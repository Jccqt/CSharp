using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Problem: Given an array of strings strs, group the anagrams together.
    // You can return the answer in any order.

    // Example 1
    // Input: strs = ["eat","tea","tan","ate","nat","bat"]
    // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
    // Explanation:
    // * There is no string in strs that can be rearranged to form "bat".
    // * The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
    // * The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
    public class GroupAnagrams
    {
        // Time Complexity: O(n * k)
        // Space Complexity: O(n * k)
        public IList<IList<string>> GetGroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            foreach(string s in strs)
            {
                int[] char_counts = new int[26];

                foreach(char c in s.ToCharArray())
                {
                    char_counts[c - 'a']++;
                }

                string key = string.Join(", ", char_counts);

                if (!result.ContainsKey(key))
                {
                    result[key] = new List<string>();
                }

                result[key].Add(s);
            }

            return result.Values.Cast<IList<string>>().ToList();
        }
    }
}
