using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class IncreasingTripletSubsequenceTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new IncreasingTripletSubsequence();

            // Act
            var result = solver.IncreasingTriplet([1, 2, 3, 4, 5]);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new IncreasingTripletSubsequence();

            // Act
            var result = solver.IncreasingTriplet([5, 4, 3, 2, 1]);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new IncreasingTripletSubsequence();

            // Act
            var result = solver.IncreasingTriplet([2, 1, 5, 0, 4, 6]);

            // Assert
            Assert.True(result);
        }
    }
}
