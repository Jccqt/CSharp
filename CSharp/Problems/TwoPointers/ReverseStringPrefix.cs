using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // You are given a string s and an integer k.
    
    // Reverse the first k characters of s and return the resulting string.

    // Example 1
    // Input: s = "abcd", k = 2
    // Output: "bacd"

    // Example 2
    // Input: s = "xyz", k = 3
    // Output: "zyx"

    // Example 3
    // Input: s = "hey", k = 1
    // Output: "hey"
    public class ReverseStringPrefix
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public string ReversePrefix(string s, int k)
        {
            if (s.Length < k) return s;
            int left = 0;
            int right = k - 1;
            char[] chars = s.ToCharArray();

            while (left < right)
            {
                char holder = chars[left];
                chars[left] = chars[right];
                chars[right] = holder;

                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
