using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow.VariableSized
{
    // You are visiting a farm that has a single row of fruit trees arranged from left to right.
    // The trees are represented by an integer array fruits where fruits[i] is the type of fruit the ith trees produces.

    // You want to collect as much fruit as possible. However, the owner has some strict rules that you must follow:
    // * You only have two baskets, and each basket can only hold a single type of fruit. There is no limit on the amount of fruit each basket can hold.
    // * Starting from any tree of your choice, you must pick exactly one fruit from every tree (including the start tree) while moving to the right.
    //   The picked fruits must fit in one of your baskets.
    // * Once you reach a tree with fruit that cannot fit in your baskets, you must stop.

    // Given the integer array fruits, return the maximum number of fruits you can pick.

    // Example 1
    // Input: fruits = [1,2,1]
    // Output: 3

    // Example 2
    // Input: fruits = [0,1,2,2]
    // Output: 3

    // Example 3
    // Input: fruits = [1,2,3,2,2]
    // Output: 4
    public class FruitIntoBaskets
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int TotalFruit(int[] fruits)
        {
            var freq = new Dictionary<int, int>();
            int longest = 0;
            int left = 0;

            for (int right = 0; right < fruits.Length; right++)
            {
                if (!freq.ContainsKey(fruits[right])) freq.Add(fruits[right], 0);
                freq[fruits[right]]++;

                while (freq.Count == 3)
                {
                    freq[fruits[left]]--;

                    if (freq[fruits[left]] == 0)
                    {
                        freq.Remove(fruits[left]);
                    }

                    left++;
                }

                longest = Math.Max(longest, right - left + 1);
            }

            return longest;
        }
    }
}
