using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class FindTheDifferenceOfTwoArraysTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FindTheDifferenceOfTwoArrays();

            // Act
            var result = solver.FindDifference(new int[] {1, 2, 3}, new int[] {2, 4, 6});

            // Assert
            var expected = new List<IList<int>>
            {
                new List<int> { 1, 3 },
                new List<int> { 4, 6 }
            };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FindTheDifferenceOfTwoArrays();

            // Act
            var result = solver.FindDifference(new int[] { 1, 2, 3, 3 }, new int[] { 1, 1, 2, 2 });

            // Assert
            var expected = new List<IList<int>>
            {
                new List<int> { 3 },
                new List<int> { }
            };

            Assert.Equal(expected, result);
        } 
    }
}
