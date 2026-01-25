using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using CSharp.Problems.TwoPointers;

namespace CSharp.Tests.TwoPointers
{
    public class MergeStringsAlternatelyTests
    {
        [Fact]
        public void Example1()
        {
            // Arrange
            var solver = new MergeStringsAlternately();

            // Act
            var result = solver.MergeAlternately("abc", "pqr");

            // Assert
            Assert.Equal("apbqcr", result);
        }

        [Fact]
        public void Example2()
        {
            // Arrange
            var solver = new MergeStringsAlternately();

            // Act
            var result = solver.MergeAlternately("ab", "pqrs");

            // Assert
            Assert.Equal("apbqrs", result);
        }

        [Fact]
        public void Example3()
        {
            // Arrange
            var solver = new MergeStringsAlternately();

            // Act
            var result = solver.MergeAlternately("abcd", "pq");

            // Assert
            Assert.Equal("apbqcd", result);
        }
    }
}
