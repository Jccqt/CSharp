using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Problems
{
    public class TwoSum
    {
        public int[] GetTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (dictionary.ContainsKey(complement))
                {
                    return new int[] { dictionary[complement], i };
                }

                dictionary[nums[i]] = i;
            }

            throw new ArgumentException("No match found!");
        }
    }
}
