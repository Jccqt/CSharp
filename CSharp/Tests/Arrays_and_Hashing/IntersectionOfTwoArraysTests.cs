using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class IntersectionOfTwoArraysTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new IntersectionOfTwoArrays();

            // Act
            var result = solver.Intersection([1, 2, 2, 1], [2, 2]);

            // Assert
            Assert.Equal([2], result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new IntersectionOfTwoArrays();

            // Act
            var result = solver.Intersection([4, 9, 5], [9, 4, 9, 8, 4]);

            // Assert
            Assert.Equal([9, 4], result);
        }
    }
}
