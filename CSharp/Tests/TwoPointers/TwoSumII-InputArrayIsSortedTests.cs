using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class TwoSumII_InputArrayIsSortedTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new TwoSumII_InputArrayIsSorted();

            // Act
            var result = solver.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            // Assert
            Assert.Equal(new int[] { 1, 2 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new TwoSumII_InputArrayIsSorted();

            // Act
            var result = solver.TwoSum(new int[] { 2, 3, 4 }, 6);

            // Assert
            Assert.Equal(new int[] { 1, 3 }, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new TwoSumII_InputArrayIsSorted();

            // Act
            var result = solver.TwoSum(new int[] { -1, 0 }, -1);

            // Assert
            Assert.Equal(new int[] {1,2}, result);
        }
    }
}
