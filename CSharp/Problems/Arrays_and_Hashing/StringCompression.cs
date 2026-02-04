using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an array of characters chars, compress it using the following algorithm:

    // Begin with an empty string s. For each group of consecutive repeating characters in chars:
    // * If the group's length is 1, append the character to s.
    // * Otherwise, append the character followed by the group's length.

    // The compressed string s should not be returned separately, but instead, be stored in the input character
    // array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

    // After you are done modifying the input array, return the new length of the array.

    // You must write an algorithm that uses only constant extra space.

    // Note: The characters in the array beyond the returned length do not matter and should be ignored.

    // Example 1
    // Input: chars = ["a","a","b","b","c","c","c"]
    // Output: 6

    // Example 2
    // Input: chars = ["a"]
    // Output: 1

    // Example 3
    // Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
    // Output: 12
    public class StringCompression
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public int Compress(char[] chars)
        {
            int index = 0;
            int i = 0;

            while (i < chars.Length)
            {
                int groupLength = 0;
                char currentChar = chars[i];

                while (i < chars.Length && chars[i] == currentChar)
                {
                    i++;
                    groupLength++;
                }

                chars[index++] = currentChar;

                if (groupLength > 1)
                {
                    foreach (char c in groupLength.ToString())
                    {
                        chars[index++] = c;
                    }
                }
            }

            return index;
        }
    }
}
