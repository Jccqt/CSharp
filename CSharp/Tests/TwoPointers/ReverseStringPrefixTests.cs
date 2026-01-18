using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class ReverseStringPrefixTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new ReverseStringPrefix();

            // Act
            var result = solver.ReversePrefix("abcd", 2);

            // Assert
            Assert.Equal("bacd", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new ReverseStringPrefix();

            // Act
            var result = solver.ReversePrefix("xyz", 3);

            // Assert
            Assert.Equal("zyx", result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new ReverseStringPrefix();

            // Act
            var result = solver.ReversePrefix("hey", 1);

            // Assert
            Assert.Equal("hey", result);
        }
    }
}
