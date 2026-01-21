using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class SortArrayByParityTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new SortArrayByParity();

            // Act
            var result = solver.SortByParity(new int[] { 3, 1, 2, 4 });

            // Assert
            Assert.Equal(new int[] { 4, 2, 1, 3 }, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new SortArrayByParity();

            // Act
            var result = solver.SortByParity(new int[] { 0 });

            // Assert
            Assert.Equal(new int[] {0}, result);
        }
    }
}
