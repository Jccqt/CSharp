using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class TwoSumTests
    {
        [Fact]
        public void SingleCase()
        {
            var solver = new TwoSum();
            var result = solver.GetTwoSum(new int[] { 2, 7, 11, 15 }, 9);

            Assert.Equal(new int[] { 0, 1 }, result);
        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void MultipleCases(int[] nums, int target, int[] expected)
        {
            var solver = new TwoSum();
            var result = solver.GetTwoSum(nums, target);

            Assert.Equal(expected, result);
        }
    }
}
