using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // Given two arrays of strings list1 and list2, find the common strings with the least index sum.

    // A common string is a string that appeared in both list1 and list2.

    // A common string with the least index sum is a common string such that if appeared 
    // at list1[i] and list2[j] then i + j should be the minimum value among all other common strings.

    // Return all the common strings with the least index sum. Return the answer in any order.

    // Example 1
    // Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["Piatti","The Grill at Torrey Pines","Hungry Hunter Steakhouse","Shogun"]
    // Output: ["Shogun"]

    // Example 2
    // Input: list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KFC","Shogun","Burger King"]
    // Output: ["Shogun"]

    // Example 3
    // Input: list1 = ["happy","sad","good"], list2 = ["sad","happy","good"]
    // Output: ["sad", "happy"]
    public class MinimumIndexSumOfTwoLists
    {
        // Time complexity: O(N + M)
        // Space complexity: O(N)
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            var result = new List<string>();
            var dictionary = new Dictionary<string, int>();
            int minSum = Int32.MaxValue;

            for (int i = 0; i < list1.Length; i++)
            {
                dictionary.Add(list1[i], i);
            }

            for (int i = 0; i < list2.Length; i++)
            {
                if (dictionary.ContainsKey(list2[i]))
                {
                    int currentSum = dictionary[list2[i]] + i;

                    if (currentSum < minSum)
                    {
                        result.Clear();
                        result.Add(list2[i]);
                        minSum = currentSum;
                    }

                    else if (currentSum == minSum)
                    {
                        result.Add(list2[i]);
                    }
                }
            }

            return result.ToArray();
        }
    }
}
