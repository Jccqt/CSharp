using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // There are n kids with candies. You are given an integer array candies, where each candies[i] represents the number 
    // of candies the ith kid has, and an integer extraCandies, denoting the number of extra candies that you have.

    // Return a boolean array result of length n, where result[i] is true if, after giving the ith kid all the 
    // extraCandies, they will have the greatest number of candies among all the kids, or false otherwise.

    // Note that multiple kids can have the greatest number of candies.

    // Example 1
    // Input: candies = [2,3,5,1,3], extraCandies = 3
    // Output: [true,true,true,false,true]

    // Example 2
    // Input: candies = [4,2,1,1,2], extraCandies = 1
    // Output: [true,false,false,false,false]

    // Example 3
    // Input: candies = [12,1,12], extraCandies = 10
    // Output: [true,false,true]
    public class KidsWithTheGreatestNumberOfCandies
    {
        // Time complexity: O(N)
        // Space complexity: O(N)
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var result = new List<bool>();
            int max = 0;

            for (int i = 0; i < candies.Length; i++)
            {
                if (candies[i] > max) max = candies[i];
            }

            foreach (int candy in candies)
            {
                if (candy + extraCandies >= max)
                {
                    result.Add(true);
                }
                else
                {
                    result.Add(false);
                }
            }

            return result;
        }
    }
}
