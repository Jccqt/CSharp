using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.Arrays_and_Hashing;

namespace CSharp.Tests.Arrays_and_Hashing
{
    public class FindTheDifferenceTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new FindTheDifference();

            // Act
            var result = solver.FindDifference("abcd", "abcde");

            // Assert
            Assert.Equal('e', result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new FindTheDifference();

            // Act
            var result = solver.FindDifference("", "y");

            // Assert
            Assert.Equal('y', result);
        }
    }
}
