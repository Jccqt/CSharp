using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class UniqueNumberOfOccurrencesTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new UniqueNumberOfOccurrences();

            // Act
            var result = solver.UniqueOccurences(new int[] { 1, 2, 2, 1, 1, 3 });

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new UniqueNumberOfOccurrences();

            // Act
            var result = solver.UniqueOccurences(new int[] { 1, 2 });

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new UniqueNumberOfOccurrences();

            // Act
            var result = solver.UniqueOccurences(new int[] { -3, 0, 1, -3, 1, 1, 1, -3, 10, 0 });

            // Assert
            Assert.True(result);
        }
    }
}
