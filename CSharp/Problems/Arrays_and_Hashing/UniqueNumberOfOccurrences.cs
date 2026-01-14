using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given an array of integers arr, return true if the number of occurences of each 
    // value in the array is unique or false otherwise.

    // Example 1
    // Input: arr = [1,2,2,1,1,3]
    // Output: true

    // Example 2
    // Input: arr = [1,2]
    // Output: false

    // Example 3
    // Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
    // Output: true
    public class UniqueNumberOfOccurrences
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public bool UniqueOccurences(int[] arr)
        {
            var dictionary = new Dictionary<int, int>();
            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dictionary.TryAdd(arr[i], 1))
                {
                    dictionary[arr[i]]++;
                }
            }

            foreach (var num in dictionary)
            {
                if (!set.Add(num.Value)) return false;
            }

            return true;
        }
    }
}
