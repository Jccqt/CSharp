using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class MaxNumberOfK_SumPairsTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MaxNumberOfK_SumPairs();

            // Act
            var result = solver.MaxOperations([1, 2, 3, 4], 5);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MaxNumberOfK_SumPairs();

            // Act
            var result = solver.MaxOperations([3, 1, 3, 4, 3], 6);

            // Assert
            Assert.Equal(1, result);
        }
    }
}
