using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems.SlidingWindow
{
    internal class MaximumAverageSubarrayI
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double currentSum = 0;

            for (int i = 0; i < k; i++)
            {
                currentSum += nums[i];
            }

            double maxSum = currentSum;

            for (int i = k; i < nums.Length; i++)
            {
                currentSum = (nums[i] - nums[i - k]) + currentSum;

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum / k;
        }
    }
}
