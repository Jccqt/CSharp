using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.TwoPointers
{
    // You are given an integer array height of length n. There are n vertical lines drawn 
    // such that the two endpoints of the ith line are (i,0) and (i, height[i]).

    // Find two lines that together with the x-axis form a container, such that the container contains the most water.

    // Return the maximum amount of water a container can store. 

    // Notice that you may not slant the container.

    // Example 1
    // Input: height = [1,8,6,2,5,4,8,3,7]
    // Output: 49

    // Example 2
    // Input: height = [1,1]
    // Output: 1
    public class ContainerWithMostWater
    {
        // Time complexity: O(N)
        // Space complexity: O(1)
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;

            while (left < right)
            {
                maxArea = Math.Max(ComputeArea(right - left, Math.Min(height[left], height[right])), maxArea);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;
        }

        public int ComputeArea(int distance, int height)
        {
            return distance * height;
        }
    }
}
