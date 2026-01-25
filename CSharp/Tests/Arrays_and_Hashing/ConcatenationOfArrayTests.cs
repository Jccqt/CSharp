using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class ConcatenationOfArrayTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ConcatenationOfArray();

            // Act
            var result = solver.GetConcatenation(new int[] { 1, 2, 1 });

            // Assert
            Assert.Equal(new int[] { 1, 2, 1, 1, 2, 1 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ConcatenationOfArray();

            // Act
            var result = solver.GetConcatenation(new int[] { 1, 3, 2, 1 });

            // Assert
            Assert.Equal(new int[] { 1, 3, 2, 1, 1, 3, 2, 1 }, result);
        }
    }
}
