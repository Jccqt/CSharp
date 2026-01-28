using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.Arrays_and_Hashing
{
    // You have a long flowerbed in which some of the plots are planted, and some are not.
    // However, flowers cannot be planted in adjacent plots.

    // Given an integer array flowerbed containing 0's and 1's where 0 means empty and 
    // 1 means not empty, and an integer n, return true if n new flowers can be planted 
    // in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

    // Example 1
    // Input: flowerbed = [1,0,0,0,1], n = 1
    // Output: true

    // Example 2
    // Input: flowerbed = [1,0,0,0,1], n = 2
    // Output: false
    public class CanPlaceFlowers
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public bool CanPlaceFlower(int[] flowerbed, int n)
        {
            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    bool left = (i == 0) || (flowerbed[i - 1] == 0);
                    bool right = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

                    if (left && right)
                    {
                        flowerbed[i] = 1;
                        n--;
                    }
                }
            }

            return n <= 0;
        }
    }
}
