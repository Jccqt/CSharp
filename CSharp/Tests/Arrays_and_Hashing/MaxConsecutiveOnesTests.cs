using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class MaxConsecutiveOnesTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MaxConsecutiveOnes();

            // Act
            var result = solver.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MaxConsecutiveOnes();

            // Act
            var result = solver.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 });

            // Assert
            Assert.Equal(2, result);
        }
    }
}
