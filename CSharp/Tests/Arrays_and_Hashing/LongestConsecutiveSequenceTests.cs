using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Problems.Arrays_and_Hashing;
using Xunit;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class LongestConsecutiveSequenceTests
    {
        [Fact]
        public void NonsortedArray()
        {
            // Arrange
            var solver = new LongestConsecutiveSequence();

            // Act
            var result = solver.LongestConsecutive(new int[] { 100, 4, 200, 1, 3, 2 });

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void SortedArray()
        {
            // Arrange
            var solver = new LongestConsecutiveSequence();

            // Act
            var result = solver.LongestConsecutive(new int[] { 1, 2, 3, 4 });

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void OneSequenceArray()
        {
            // Arrange
            var solver = new LongestConsecutiveSequence();

            // Act
            var result = solver.LongestConsecutive(new int[] { 0, 3, 99, 21, 29 });

            // Assert
            Assert.Equal(1, result);
        }
    }
}
