using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class ShuffleTheArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ShuffleTheArray();

            // Act
            var result = solver.Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);

            // Assert
            Assert.Equal(new int[] { 2, 3, 5, 4, 1, 7 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ShuffleTheArray();

            // Act
            var result = solver.Shuffle(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);

            // Assert
            Assert.Equal(new int[] { 1, 4, 2, 3, 3, 2, 4, 1 }, result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ShuffleTheArray();

            // Act
            var result = solver.Shuffle(new int[] { 1, 1, 2, 2 }, 2);

            // Assert
            Assert.Equal(new int[] { 1, 2, 1, 2 }, result);
        }
    }
}
